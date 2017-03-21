using System.Collections.Generic;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain.UserReferences
{
    /// <summary>
    /// Пользовательский справочник
    /// </summary>
    public class Reference:IEntity
    {

        public ICollection<ReferenceValue> values = new HashSet<ReferenceValue>();

        public int Id { get; set; }
        /// <summary>
        /// Наименование справочника
        /// </summary>
        public string Name { get; set; }

        public IEnumerable<ReferenceValue> Values { get; set; }

        public void AddValue(ReferenceValue value)
        {
            value.Reference = this;
            values.Add(value);
        }
    }
}
