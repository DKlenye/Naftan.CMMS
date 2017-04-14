using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.RepairObjects
{
    /// <summary>
    /// Подразделение
    /// </summary>
    public class Department:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
