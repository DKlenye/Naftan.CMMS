using Naftan.CMMS.Domain.RepairObjects;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Specifications
{
    /// <summary>
    /// Групповая тех. характеристика
    /// </summary>
    public class GroupSpecification:IEntity
    {
        public GroupSpecification(Specification specification)
        {
            Specification = specification;
        }

        public int Id { get; set; }
        public RepairObjectGroup Group { get; set; }
        public Specification Specification { get; private set; }
        public string DefaultValue { get; set; }
    }
}
