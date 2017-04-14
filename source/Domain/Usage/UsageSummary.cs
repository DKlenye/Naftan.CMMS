using System;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Usage
{
    /// <summary>
    /// Наработка суммарная
    /// </summary>
    public class UsageSummary:IEntity
    {
        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public MaintenanceType MaintenanceType { get; set; }
        public DateTime LastMaintenanceDate { get; set; }

        /// <summary>
        /// Наработка с последнего обслуживания, если межремонтный интервал по времени, то наработка не учитывается
        /// </summary>
        public int? UsageFromLastMaintenance { get; set; }
    }
}
