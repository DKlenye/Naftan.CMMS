using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.SimpleDomain
{
    /// <summary>
    /// Марка оборудования
    /// </summary>
    public class RepairObjectModel:IEntity
    {
        public int Id { get; set; }
        public RepairObjectGroup Group { get; set; }
        public string Name { get; set; }
    }
}
