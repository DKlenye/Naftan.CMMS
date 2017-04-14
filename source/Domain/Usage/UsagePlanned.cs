using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Usage
{
    /// <summary>
    /// Плановая наработка
    /// </summary>
    public class UsagePlanned:IEntity
    {
        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public TimePeriod TimePeriod { get; set; }
        public int PeriodQuantity { get; set; }
        public int Usage { get; set; }
    }
}