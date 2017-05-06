using System;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.RepairObjects;

namespace Naftan.CMMS.Domain
{
    public interface ICommandFactory
    {
        /// <summary>
        /// Добавить обслуживание
        /// </summary>
        void AddMaintenance(
            RepairObject repairObject,
            MaintenanceType maintenanceType,
            DateTime start,
            DateTime? end,
            MaintenanceReason unplannedReason);

        /// <summary>
        /// Завершить неоконченное обслуживание
        /// </summary>
        /// <param name="maintenance">обслуживание</param>
        /// <param name="end">дата завершения</param>
        void FinalizeMaintenance(
            MaintenanceActual maintenance,
            DateTime end
        );
        
        /// <summary>
        /// Спланировать обслуживание
        /// </summary>
        void PlanningMaintenance();

        /// <summary>
        /// Добавить наработку
        /// </summary>
        void AddUsage(RepairObject repairObject, DateTime start, DateTime end, int usage);
    }
}