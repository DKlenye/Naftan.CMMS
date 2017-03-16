using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain
{
    /// <summary>
    /// Установка
    /// </summary>
    public class Plant:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}
