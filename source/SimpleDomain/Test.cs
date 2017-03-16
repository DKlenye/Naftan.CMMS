using System.Collections.Specialized;

namespace Naftan.CMMS.SimpleDomain
{
    public class Test
    {
        public void CreateNewObject()
        {
            var model = new RepairObjectModel
            {
                Name = "ВА572-2",
                Group = new RepairObjectGroup
                {
                    Name = "ЭД синхронный с к.з. ротором",
                    Type = RepairObjectType.ElectroMotor
                }
            };

            var eMotor = new ElectroMotor(model)
            {
                FactoryNumber = "3452",
                InventoryNumber = "123456678",
                Power = 12.3M,
                RPM = 5000
            };
        }
    }
}