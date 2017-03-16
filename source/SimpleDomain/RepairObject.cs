using System;
using Naftan.Infrastructure.Domain;

namespace Naftan.CMMS.SimpleDomain
{
    public abstract class RepairObject : IEntity
    {
        protected RepairObject(RepairObjectModel model)
        {
            if (model.Group.Type != DefaultType)
                throw new Exception("Неверно указана модель");
            Model = model;
        }

        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public RepairObjectModel Model { get; private set; }
        public Environment Environment { get; set; }
        public int EnvironmentTemperature { get; set; }
        public Producer Producer { get; set; }
        public string FactoryNumber { get; set; }
        public string TechIndex { get; set; }

        protected abstract RepairObjectType DefaultType { get; }

    }
}
