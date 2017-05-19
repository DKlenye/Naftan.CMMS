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
        ///  Интервал обслуживания по наработке и по времени
        /// </summary>
        /// <param name="group"></param>
        /// <param name="maintenanceType"></param>
        /// <param name="measureUnit"></param>
        /// <param name="timePeriod"></param>
        /// <param name="periodQuantity"></param>
        /// <param name="minUsage"></param>
        /// <param name="maxUsage"></param>
        /// <param name="quantityInCycle"></param>
        public MaintenanceInterval(
            RepairObjectGroup group,
            MaintenanceType maintenanceType,
            TimePeriod timePeriod,
            int periodQuantity,
            MeasureUnit measureUnit,
            int minUsage,
            int? maxUsage = null,
            int? quantityInCycle = null
        )
        {
            IntervalType = MaintenanceIntervalType.ByUsageAndTime;
            Group = group;
            MaintenanceType = maintenanceType;
            MeasureUnit = measureUnit;
            TimePeriod = timePeriod;
            PeriodQuantity = periodQuantity;
            MinUsage = minUsage;
            QuantityInCycle = quantityInCycle;
            MaxUsage = maxUsage;
        }

        /// <summary>
        /// Интервал обслуживания по наработке
        /// </summary>
        /// <param name="group"></param>
        /// <param name="maintenanceType"></param>
        /// <param name="measureUnit"></param>
        /// <param name="minUsage"></param>
        /// <param name="maxUsage"></param>
        /// <param name="quantityInCycle"></param>
        public MaintenanceInterval(
            RepairObjectGroup group,
            MaintenanceType maintenanceType,
            MeasureUnit measureUnit,
            int minUsage, 
            int? maxUsage = null,
            int? quantityInCycle = null
        )
        {
            IntervalType = MaintenanceIntervalType.ByUsage;
            Group = group;
            MaintenanceType = maintenanceType;
            MeasureUnit = measureUnit;
            MinUsage = minUsage;
            QuantityInCycle = quantityInCycle;
            MaxUsage = maxUsage;
        }

        /// <summary>
        /// Интервал обслуживания по времени
        /// </summary>
        /// <param name="group"></param>
        /// <param name="maintenanceType"></param>
        /// <param name="timePeriod"></param>
        /// <param name="periodQuantity"></param>
        /// <param name="quantityInCycle"></param>
        public MaintenanceInterval(
            RepairObjectGroup group,
            MaintenanceType maintenanceType,
            TimePeriod timePeriod,
            int periodQuantity,
            int? quantityInCycle = null
        )
        {
            IntervalType = MaintenanceIntervalType.ByTime;
            Group = group;
            TimePeriod = timePeriod;
            PeriodQuantity = periodQuantity;
            MaintenanceType = maintenanceType;
            QuantityInCycle = quantityInCycle;
        }

        public int Id { get; set; }

        public RepairObjectGroup Group { get; private set; }
        public MaintenanceType MaintenanceType { get; private set; }
        public MaintenanceIntervalType IntervalType { get; private set; }
        
        #region По наработке
        /// <summary>
        /// Единица измерения наработки
        /// </summary>
        public MeasureUnit MeasureUnit { get; private set; }
        
        /// <summary>
        /// Наработка минимальная. 
        /// </summary>
        public int? MinUsage { get; private set; }

        /// <summary>
        /// Наработка максимальная. Её может не быть
        /// </summary>
        public int? MaxUsage { get; private set; }

        #endregion
        
        #region По времени

        public TimePeriod? TimePeriod { get; private set; }

        public int? PeriodQuantity { get; private set; }

        #endregion
        
        /// <summary>
        /// Количество в структуре межремонтного цикла
        /// todo может и не быть, а как тогда определить приоритет ремонтов? по наработке или по временым интервалам
        /// </summary>
        public int? QuantityInCycle { get; private set; }
    }
}