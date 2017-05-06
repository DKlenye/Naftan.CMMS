using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Причина проведения обслуживания
    /// </summary>
    public class MaintenanceReason:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}