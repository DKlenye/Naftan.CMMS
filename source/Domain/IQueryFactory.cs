using System.Collections.Generic;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.Usage;

namespace Naftan.CMMS.Domain
{
    public interface IQueryFactory
    {
        IEnumerable<LastMaintenance> FindLastMaintenanceByObjectId(int objectId);
        IEnumerable<MaintenanceInterval> FindMaintenanceIntervalsByObjectId(int objectId);
        UsagePlanned FindUsagePlannedByObjectId(int objectId);
    }
}