using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.UserReferences
{
    /// <summary>
    /// Значение пользовательского справочника
    /// </summary>
    public class ReferenceValue:IEntity
    {
        public int Id { get; set; }
        public Reference Reference { get; set; }
        /// <summary>
        /// Значение справочника
        /// </summary>
        public string Value { get; set; }
    }
}