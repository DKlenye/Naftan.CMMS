using System;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Проведённое обслуживание (Журнал обслуживания)
    /// </summary>
    public class MaintenanceActual:IEntity
    {
        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public MaintenanceType Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public UnplannedMaintenanceReason UnplannedReason { get; set; }
    }
}