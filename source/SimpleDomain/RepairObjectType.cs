using System;
using System.ComponentModel;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.SimpleDomain
{
    /// <summary>
    /// Вид оборудования
    /// </summary>
    public enum RepairObjectType
    {
        [Description("Электромотор")]
        ElectroMotor = 1,

        [Description("Компрессор")]
        Compressor = 2,

        [Description("ГПМ")]
        LiftingMechanism = 3
    }
}