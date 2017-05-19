using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Тип обслуживания
    /// </summary>
    public class MaintenanceType:IEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Обозначение
        /// </summary>
        public string Designation { get; set; }
    }
}
