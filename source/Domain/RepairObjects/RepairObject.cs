using System;
using System.Collections.Generic;
using System.Linq;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.Specifications;
using Naftan.CMMS.Domain.Usage;
using Naftan.Infrastructure.Domain;
using Naftan.Infrastructure.Domain.EntityComponents;

namespace Naftan.CMMS.Domain.RepairObjects
{
    /// <summary>
    /// Объект ремонта
    /// </summary>
    public class RepairObject:TreeNode<RepairObject>, IEntity
    {
        private readonly ICollection<ObjectSpecification> specifications = new HashSet<ObjectSpecification>();
        private readonly ICollection<ObjectOperatingState> states = new HashSet<ObjectOperatingState>();

        public RepairObject(RepairObjectGroup group, DateTime startOperating)
        {
            Group = group;
            AddSpecificationsFromGroup(group);
            StartOperating = startOperating;
            ChangeOperatingState(OperatingState.Operating, startOperating);
        }

        public int Id { get; set; }
        /// <summary>
        /// Группа объекта ремонта
        /// </summary>
        public RepairObjectGroup Group { get; private set; }
        /// <summary>
        /// Установка
        /// </summary>
        public Plant Plant { get; set; }
        /// <summary>
        /// Рабочая среда
        /// </summary>
        public Environment Environment { get; set; }
        /// <summary>
        /// Завод производитель
        /// </summary>
        public Manufacturer Manufacturer { get; set; }
        /// <summary>
        ///Дата изготовления 
        /// </summary>
        public DateTime ManufactureDate { get; set; }
        /// <summary>
        /// Заводской номер
        /// </summary>
        public string FactoryNumber { get; set; }
        /// <summary>
        /// Инвентарный номер
        /// </summary>
        public string InventoryNumber { get; set; }
        /// <summary>
        /// Технологический индекс
        /// </summary>
        public string TechIndex { get; set; }
        
        /// <summary>
        /// Дата ввода в эксплуатацию
        /// </summary>
        public DateTime StartOperating { get; private set; }

        
        #region Рабочее состояние

        /// <summary>
        /// Текущее рабочее состояние
        /// </summary>
        public OperatingState CurrentOperatingState { get; private set; }

        /// <summary>
        /// История изменения состояния эксплуатации
        /// </summary>
        public IEnumerable<ObjectOperatingState> OperatingStates => states;

        /// <summary>
        /// Изменить рабочее состояние объекта ремонта
        /// </summary>
        /// <param name="state">Рабочее состояние</param>
        /// <param name="startDate">Дата изменения состояния</param>
        public void ChangeOperatingState(OperatingState state, DateTime startDate)
        {
            if (CurrentOperatingState != state)
            {
                CurrentOperatingState = state;
                states.Add(new ObjectOperatingState
                {
                    State = state,
                    Object = this,
                    StartDate = startDate
                });
            }
        }

        #endregion
        
        #region Технические характеристики

        /// <summary>
        /// Технические характеристики
        /// </summary>
        public IEnumerable<ObjectSpecification> Specifications => specifications;

        /// <summary>
        /// Добавить техническую характеристику
        /// </summary>
        /// <param name="specification"></param>
        public void AddSpecification(ObjectSpecification specification)
        {
            if (specifications.All(f => f.Specification.Id != specification.Specification.Id)){
                specification.Object = this;
                specifications.Add(specification);
            }
        }

        /// <summary>
        /// Добавить технические характеристики из группы (цепочки родителей)
        /// </summary>
        /// <param name="group"></param>
        private void AddSpecificationsFromGroup(RepairObjectGroup group)
        {
            group.Specifications.ToList().ForEach(f=>AddSpecification(new ObjectSpecification {Specification = f.Specification,Value = f.DefaultValue}));
            if(group.Parent!=null)
                AddSpecificationsFromGroup(group.Parent);
        }

        #endregion

        #region Наработка

        /// <summary>
        /// Наработка с начала экслуатации
        /// </summary>
        public int UsageFromStartup { get; private set; }

        /// <summary>
        /// Добавить наработку
        /// </summary>
        /// <param name="start">Дата с</param>
        /// <param name="end">Дата по</param>
        /// <param name="usage">Наработка</param>
        public void AddUsage(DateTime start, DateTime end, int usage)
        {
            //Добавить запись в журнал наработки
            //Добавить наработку в суммарную наработку 
            

            //Добавить наработку с начала эксплуатации
            UsageFromStartup += usage;
        }

        #endregion

        #region Планирование ремонтных работ

        public void PlanMaintenance(Period period)
        {
            //Посмотреть межремонтные интервалы
            //Если подходит ремонт, то добавить запись в график ППР
        }

        #endregion

        #region Ремонтные работы

        public void AddMaintenance(MaintenanceType type, DateTime start, DateTime? end = null, UnplannedMaintenanceReason unplannedReason = null)
        {
            //Добавить запись в журнал обслуживания
            //
        }

        #endregion
        
    }
}
