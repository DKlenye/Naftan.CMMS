using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Specifications
{
    public class GroupSpecification:IEntity
    {
        public GroupSpecification(Specification specification)
        {
            Specification = specification;
        }

        public int Id { get; set; }
        public EquipmentGroup Group { get; set; }
        public Specification Specification { get; private set; }
        public string DefaultValue { get; set; }
    }
}
