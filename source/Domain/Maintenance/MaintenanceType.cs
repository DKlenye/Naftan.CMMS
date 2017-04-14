using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Тип обслуживания
    /// </summary>
    public class MaintenanceType:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
