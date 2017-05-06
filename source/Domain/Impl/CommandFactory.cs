using System;
using System.Linq;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.CMMS.Domain.Usage;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Impl
{
    public class CommandFactory:ICommandFactory
    {
        private readonly IQueryFactory query;
        private readonly IRepository repository;

        public CommandFactory(IQueryFactory query, IRepository repository)
        {
            this.query = query;
            this.repository = repository;
        }

        public void AddMaintenance(
            RepairObject repairObject, 
            MaintenanceType maintenanceType,
            DateTime start,
            DateTime? end,
            MaintenanceReason unplannedReason
            )
        {
            //Добавить запись в журнал обслуживания
            var maintenance = new MaintenanceActual()
            {
                Type = maintenanceType,
                Start = start,
                Object = repairObject,
                UnplannedReason = unplannedReason
            };

            repository.Save(maintenance);

            if (end!=null)
            {
                FinalizeMaintenance(maintenance,end.Value);
            }
            
        }

        public void FinalizeMaintenance(MaintenanceActual maintenance, DateTime end)
        {
            //Сохраняем дату завершения обслуживания
            maintenance.End = end;
            repository.Save(maintenance);

            var objectId = maintenance.Object.Id;

            //Найти интервалы объекта
            var intervals = query.FindMaintenanceIntervalsByObjectId(objectId);

            //Взять интересующий интервал по типу обслуживания
            var targetInterval = intervals.SingleOrDefault(x => x.MaintenanceType == maintenance.Type);

            if (targetInterval == null)
            {
                throw new Exception("Не найден интервал для данного вида обслуживания");
            }

            /* Выбрать интервалы для сброса. Сюда попадает интересующий нас интервал и более мелкие.
             * Т.е. Если проводится Средний ремонт, то сбрасываются Средний, Текущий и Обслуживание.
             */
            var intervalsForReset =
                intervals.Where(x => x.Quantity <= targetInterval.Quantity).ToDictionary(i => i.MaintenanceType, i => i);

            var last = query.FindLastMaintenanceByObjectId(objectId);

            last.ToList().ForEach(lm =>
            {
                if (intervalsForReset.ContainsKey(lm.MaintenanceType))
                {
                    lm.Reset(end);
                    repository.Save(lm);
                }
            });
        }

        public void PlanningMaintenance(RepairObject repairObject, DateTime start, DateTime end)
        {
            var intervals = query.FindMaintenanceIntervalsByObjectId(repairObject.Id);
            var last = query.FindLastMaintenanceByObjectId(repairObject.Id);

            var intervalType = intervals.First().IntervalType;

            switch (intervalType)
            {
                case MaintenanceIntervalType.ByTime:
                {
                    break;
                }
                case MaintenanceIntervalType.ByUsage:
                {

                    var usagePlanned = query.FindUsagePlannedByObjectId(repairObject.Id);
                    
                    //Исходя из плановой наработки нужно расчитать сколько ему осталось до ремонта
                    intervals.OrderByDescending(x => x.Quantity).ToList().ForEach(x =>
                    {

                    });


                    break;
                }
                default:
                {
                    throw new Exception("Не задан расчёт графика ППР для данного типа интервала");
                }
            }


            if (intervalType == MaintenanceIntervalType.ByUsage)
            {
                
            }

            intervals.OrderByDescending(x=>x.Quantity).ToList().ForEach(x =>
            {
                
            });


            //Посмотреть межремонтные интервалы
            //Если подходит ремонт, то добавить запись в график ППР

            throw new NotImplementedException();
        }


        public void AddUsage(RepairObject repairObject, DateTime start, DateTime end, int usage)
        {
            //todo проверить не вводилась ли наработка за этот период ранее
            
            //Добавить запись в журнал наработки
            var newUsage = new UsageActual()
            {
                Object = repairObject,
                Start = start,
                End = end,
                Usage = usage
            };
            
            repository.Save(newUsage);

            //Добавить наработку в последние ремонты 
            var lastMaintenance = query.FindLastMaintenanceByObjectId(repairObject.Id);

            lastMaintenance.ToList().ForEach(last =>
            {
                last.AddUsage(usage);
                repository.Save(last);
            });

            //Добавить наработку с начала эксплуатации
            repairObject.UsageFromStartup += usage;
            repository.Save(repairObject);
        }

        public void PlanningMaintenance()
        {
            throw new NotImplementedException();
        }
    }
}
