using System.Collections.Generic;
using System.Linq;
using Naftan.CMMS.Domain.Specifications;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain
{
    /// <summary>
    /// Объект ремонта
    /// </summary>
    public class RepairObject:TreeNode<RepairObject>, IEntity
    {
        private readonly ICollection<ObjectSpecification> specifications = new HashSet<ObjectSpecification>();

        public RepairObject(RepairObjectGroup group)
        {
            Group = group;
            AddSpecificationsFromGroup(group);
        }

        public int Id { get; set; }
        public RepairObjectGroup Group { get; private set; }
        public Plant Plant { get; set; }
        public Environment Environment { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string FactoryNumber { get; set; }
        public string InventoryNumber { get; set; }
        
        public IEnumerable<ObjectSpecification> Specifications => specifications;

        public void AddSpecification(ObjectSpecification specification)
        {
            if (specifications.All(f => f.Specification.Id != specification.Specification.Id)){
                specification.Object = this;
                specifications.Add(specification);
            }
        }

        private void AddSpecificationsFromGroup(RepairObjectGroup group)
        {
            group.Specifications.ToList().ForEach(f=>AddSpecification(new ObjectSpecification {Specification = f.Specification,Value = f.DefaultValue}));
            if(group.Parent!=null)
                AddSpecificationsFromGroup(group.Parent);
        }






    }
}
