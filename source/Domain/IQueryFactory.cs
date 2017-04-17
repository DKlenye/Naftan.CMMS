using System.Collections.Generic;
using Naftan.CMMS.Domain.Maintenance;

namespace Naftan.CMMS.Domain
{
    public interface IQueryFactory
    {
        IEnumerable<LastMaintenance> FindLastMaintenanceByObjectId(int objectId);
        IEnumerable<MaintenanceInterval> FindMaintenanceIntervalsByObjectId(int objectId);
    }
}