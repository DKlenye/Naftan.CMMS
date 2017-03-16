namespace Naftan.CMMS.SimpleDomain
{
    public class LiftingMechanism:RepairObject
    {
        public LiftingMechanism(RepairObjectModel model) : base(model)
        {
        }

        protected override RepairObjectType DefaultType => RepairObjectType.LiftingMechanism;
    }
}