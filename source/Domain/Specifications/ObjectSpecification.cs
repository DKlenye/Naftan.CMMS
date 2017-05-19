using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Specifications
{
    public class ObjectSpecification:IEntity
    {
        public ObjectSpecification(Specification specification, string value)
        {
            Specification = specification;
            Value = value;
        }

        public int Id { get; set; }
        public RepairObject Object { get; set; }
        public Specification Specification { get; private set; }
        public string Value { get; private set; }
    }
}