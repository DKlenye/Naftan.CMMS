using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.RepairObjects
{
    /// <summary>
    /// Завод изготовитель
    /// </summary>
    public class Manufacturer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}