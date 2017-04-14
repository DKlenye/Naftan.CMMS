using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;
using Naftan.Infrastructure.Domain.EntityComponents;

namespace Naftan.CMMS.Domain.Maintenance
{
    public class MaintenancePlanDetails:IEntity
    {
        public int Id { get; set; }
        public MaintenancePlan Plan { get; set; }
        public RepairObject Object { get; set; }
        public Period Period { get; set; }
        public MaintenanceType MaintenanceType { get; set; }
    }
}
