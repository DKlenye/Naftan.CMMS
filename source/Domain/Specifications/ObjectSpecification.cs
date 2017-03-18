using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Specifications
{
    public class ObjectSpecification:IEntity
    {
        public int Id { get; set; }
        public Equipment Object { get; set; }
        public Specification Specification { get; set; }
        public string Value { get; set; }
    }
}