using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;
using Naftan.Infrastructure.Domain.EntityComponents;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Предложения к плану на следующий период
    /// </summary>
    public class MaintenanceOffer:IEntity
    {
        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public Period Period { get; set; }
        private MaintenanceType MaintenanceType { get; set; }
        private MaintenanceReason Reason { get; set; }
    }
}