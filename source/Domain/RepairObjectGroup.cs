using System.Collections.Generic;
using System.Linq;
using Naftan.CMMS.Domain.Specifications;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain
{
    /// <summary>
    /// Группа объекта ремонта
    /// </summary>
    public class RepairObjectGroup:TreeNode<RepairObjectGroup>, IEntity
    {
        private readonly IList<GroupSpecification> specifications = new List<GroupSpecification>();

        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<MaintenanceInterval> Intervals { get; set; }

        public IEnumerable<GroupSpecification> Specifications => specifications;

        public void AddSpecification(GroupSpecification specification)
        {
            if (specifications.All(f=>f.Specification.Id!=specification.Id))
            {
                specification.Group = this;
                specifications.Add(specification);
            }
        }
    }
}