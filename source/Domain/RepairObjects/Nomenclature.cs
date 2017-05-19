using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.RepairObjects
{
    public class Nomenclature:TreeNode<Nomenclature>,IEntity
    {
        public int Id { get; set; }
    }
}
