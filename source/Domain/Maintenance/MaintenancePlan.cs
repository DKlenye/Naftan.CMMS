using System;
using System.Collections.Generic;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;
using Naftan.Infrastructure.Domain.EntityComponents;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// График ППР
    /// </summary>
    public class MaintenancePlan:IEntity
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<MaintenancePlanDetails> Details { get; set; }
    }
}