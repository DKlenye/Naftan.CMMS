using System;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.RepairObjects;

namespace Naftan.CMMS.Domain.Dto
{
    public class OperationalReport
    {
        private RepairObject Object { get; set; }

        public MaintenanceType PlannedMaintenanceType { get; set; }
        public MaintenanceType ActualMaintenanceType { get; set; }
        public MaintenanceReason UnplannedReason { get; set; }
        public int UsageBeforeMaintenance { get; set; }
        public int UsageAfterMaintenance{ get; set; }
        public DateTime StartMaintenance { get; set; }
        public DateTime? EndMaintenance { get; set; }
        public MaintenanceType OfferForPlanMaintenance { get; set; }
        public MaintenanceType ReasonForOffer { get; set; }
    }
}