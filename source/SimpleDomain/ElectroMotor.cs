using System;

namespace Naftan.CMMS.SimpleDomain
{
    public class ElectroMotor : RepairObject
    {
        public ElectroMotor(RepairObjectModel model) : base(model)
        {

        }

        public decimal Power { get; set; }
        public int RPM { get; set; }

        protected override RepairObjectType DefaultType => RepairObjectType.ElectroMotor;
    }
}
