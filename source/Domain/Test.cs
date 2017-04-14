using System;
using System.Linq;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.CMMS.Domain.UserReferences;
using Naftan.CMMS.Domain.Specifications;

namespace Naftan.CMMS.Domain
{
    public class Test
    {
        public void CreateNewObject()
        {

            var eMotors = new RepairObjectGroup {Name = "Электродвигатели"};
            var eMotorType = new RepairObjectGroup {Name = "ЭД синхронный с к.з. ротором"};
            var eMotorModel = new RepairObjectGroup {Name = "ВА572-2"};

            eMotors.AddChild(eMotorType);
            eMotorType.AddChild(eMotorModel);


            var execution = new Reference {Name = "Вид исполнения"};
            execution.AddValue(new ReferenceValue {Value = "Открытое"});
            execution.AddValue(new ReferenceValue {Value = "Закрытое"});


            var powerSpec = new Specification
            {
                Name = "Мощность электодвигателя",
                Type = SpecificationType.Number,
                Unit = new MeasureUnit {Name = "КВт"}
            };
            var rpmSpec = new Specification
            {
                Name = "Частота вращения",
                Type = SpecificationType.Number,
                Unit = new MeasureUnit {Name = "Об/мин"}
            };
            var executionSpec = new Specification
            {
                Id = 23,
                Name = "Исполнение",
                Type = SpecificationType.Reference,
                Reference = execution
            };

            eMotors.AddSpecification(new GroupSpecification(powerSpec));
            eMotors.AddSpecification(new GroupSpecification(rpmSpec));

            var eMotor = new RepairObject(eMotorModel, DateTime.Now)
            {
                FactoryNumber = "3452",
                InventoryNumber = "123456678",
            };


            eMotor.AddSpecification(new ObjectSpecification
            {
                Specification = executionSpec,
                Value = executionSpec.Reference.Values.First().Id.ToString()
            });


        }
    }
}