using System.ComponentModel;

namespace Naftan.CMMS.Domain.RepairObjects
{
    /// <summary>
    /// Вид эксплуатации (рабочее состояние)
    /// </summary>
    public enum OperatingState
    {
        [Description("Эксплуатируется")] Operating = 1,
        [Description("Резерв")] Reserve = 2,
        [Description("Списан")] WriteOff = 3
    }
}