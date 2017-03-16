namespace Naftan.CMMS.SimpleDomain
{
    public class Compressor:RepairObject
    {
        public Compressor(RepairObjectModel model) : base(model)
        {
        }

        protected override RepairObjectType DefaultType => RepairObjectType.Compressor;

        public decimal InjectionPressure { get; set; }
        public decimal PumpPressure { get; set; }
        public decimal Power { get; set; }
        public ElectroMotor ElectroMotor { get; set; }
    }
}