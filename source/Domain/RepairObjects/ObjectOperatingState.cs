using System;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.RepairObjects
{
    /// <summary>
    /// Состояния (история изменения рабочих состояний) объекта ремонта
    /// </summary>
    public class ObjectOperatingState:IEntity
    {
        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public DateTime StartDate { get; set; }
        public OperatingState State { get; set; }
    }
}
