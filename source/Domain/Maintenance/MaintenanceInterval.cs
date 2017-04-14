using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Интервал обслуживания
    /// </summary>
    public class MaintenanceInterval:IEntity
    {
        /// <summary>
        /// Межремонтный интервал по наработке
        /// </summary>
        /// <param name="group"></param>
        /// <param name="maintenanceType"></param>
        /// <param name="measureUnit"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="quantity"></param>
        public MaintenanceInterval(RepairObjectGroup group, MaintenanceType maintenanceType, MeasureUnit measureUnit, int? min, int max, int quantity)
        {
            IntervalType = MaintenanceIntervalType.ByUsage;
            Group = group;
            MaintenanceType = maintenanceType;
            MeasureUnit = measureUnit;
            Min = min;
            Max = max;
            Quantity = quantity;
        }

        /// <summary>
        /// Межремонтный интервал по времени
        /// </summary>
        /// <param name="group"></param>
        /// <param name="maintenanceType"></param>
        /// <param name="time"></param>
        /// <param name="max"></param>
        /// <param name="quantity"></param>
        public MaintenanceInterval(RepairObjectGroup group, MaintenanceType maintenanceType, TimePeriod time, int max, int quantity)
        {
            IntervalType = MaintenanceIntervalType.ByTime;
            Group = group;
            MaintenanceType = maintenanceType;
            TimePeriod = time;
            Max = max;
            Quantity = quantity;
        }



        public int Id { get; set; }
        
        public MaintenanceIntervalType IntervalType { get; private set; }

        public MaintenanceType MaintenanceType { get; private set; }
        public MeasureUnit MeasureUnit { get; private set; }
        public TimePeriod? TimePeriod { get; private set; }
        public RepairObjectGroup Group { get; private set; }

        /// <summary>
        /// Наработка минимальная. Её может не быть
        /// </summary>
        public int? Min { get; private set; }
        /// <summary>
        /// Наработка максимальная
        /// </summary>
        public int Max { get; private set; }

        /// <summary>
        /// Количество в структуре межремонтного цикла
        /// </summary>
        public int Quantity { get; private set; }
    }
}