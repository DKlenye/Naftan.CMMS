using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.SimpleDomain
{
    /// <summary>
    /// Группа оборудования
    /// </summary>
    public class RepairObjectGroup:IEntity
    {
        public int Id { get; set; }
        public RepairObjectType Type { get; set; }
        public string Name { get; set; }
    }
}