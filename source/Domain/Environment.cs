﻿using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.Domain
{
    /// <summary>
    /// Среда
    /// </summary>
    public class Environment:IEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Наименование среды
        /// </summary>
        public string Name { get; set; }
    }
}
