using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain
{
    public class Environment:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
