using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain
{
    /// <summary>
    /// Интервал обслуживания
    /// </summary>
    public class MaintenanceInterval:IEntity
    {
        public int Id { get; set; }

        public MaintenanceType MaintenanceType { get; set; }
        public MeasureUnit MeasureUnit { get; set; }
        public EquipmentGroup Group { get; set; }

        /// <summary>
        /// Наработка минимальная. Её может не быть
        /// </summary>
        public int? Min { get; set; }
        /// <summary>
        /// Наработка максимальная
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// Количество в структуре межремонтного цикла
        /// </summary>
        public int Quantity { get; set; }
    }
}