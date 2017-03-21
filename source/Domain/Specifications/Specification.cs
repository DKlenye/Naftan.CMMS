using Naftan.CMMS.Domain.UserReferences;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.Specifications
{
    /// <summary>
    /// Техническая характеристика
    /// </summary>
    public class Specification:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MeasureUnit Unit { get; set; }
        public SpecificationType Type { get; set; }
        public Reference Reference { get; set; }
    }
}