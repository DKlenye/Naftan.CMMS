using System.ComponentModel;

namespace Naftan.CMMS.Domain.Maintenance
{
    /// <summary>
    /// Тип межремонтного интервала по виду учёта
    /// </summary>
    public enum MaintenanceIntervalType
    {
        [Description("По наработке")]
        ByUsage = 1,

        [Description("По времени")]
        ByTime = 2
    }
}
