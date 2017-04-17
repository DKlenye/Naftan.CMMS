using System;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Последнее обслуживание
    /// </summary>
    public class LastMaintenance:IEntity
    {
        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public MaintenanceType MaintenanceType { get; set; }
        public DateTime LastMaintenanceDate { get; private set; }
        /// <summary>
        /// Наработка с последнего обслуживания, если межремонтный интервал по времени, то наработка не учитывается
        /// </summary>
        public int? UsageFromLastMaintenance { get; private set; }

        public void Reset(DateTime Date)
        {
            LastMaintenanceDate = Date;
            if (UsageFromLastMaintenance != null)
            {
                UsageFromLastMaintenance = 0;
            }
        }

        public void AddUsage(int Usage)
        {
            if (UsageFromLastMaintenance != null)
            {
                UsageFromLastMaintenance += Usage;
            }
        }
    }
}
