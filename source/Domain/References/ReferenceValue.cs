using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.References
{
    /// <summary>
    /// Значение пользовательского справочника
    /// </summary>
    public class ReferenceValue:IEntity
    {
        public int Id { get; set; }
        public Reference Reference { get; set; }
        public string Value { get; set; }
    }
}