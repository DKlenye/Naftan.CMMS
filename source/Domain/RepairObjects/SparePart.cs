using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.RepairObjects
{
    public class SparePart:IEntity
    {
        public int Id { get; set; }
        public Nomenclature Nomenclature { get; set; }
        public RepairObject Object { get; set; }
        public MeasureUnit Unit { get; set; }
        public decimal Quantity { get; set; }
    }
}