using System;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Usage
{
    /// <summary>
    /// Журнал наработки
    /// </summary>
    public class UsageActual:IEntity
    {
        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Usage { get; set; }
    }
}