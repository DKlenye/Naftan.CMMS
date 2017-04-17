using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Причина внепланового обслуживания
    /// </summary>
    public class UnplannedMaintenanceReason:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}