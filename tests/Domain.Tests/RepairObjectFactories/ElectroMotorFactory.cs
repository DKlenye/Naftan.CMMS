using System;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.CMMS.Domain.Specifications;
using Naftan.Infrastructure.Domain;

namespace Domain.Tests.RepairObjectFactories
{
    public class ElectroMotorFactory:BaseFactory
    {
        public ElectroMotorFactory(IRepository repository) : base(repository)
        {
        }

        public static RepairObject ElectroMotor { get; private set; }
        

        protected override void Build(IRepository repository)
        {
            new MaintenanceTypeFactory(repository);
            new SpecificationFactory(repository);
            new MeasureUnitFactory(repository);

            var eMotors = new RepairObjectGroup {Name = "Электродвигатели"};
            var eMotorType = new RepairObjectGroup {Name = "ЭД синхронный с к.з. ротором"};
            var eMotorModel = new RepairObjectGroup {Name = "1AN3R-355Z-6"};

            eMotors.AddChild(eMotorType);
            eMotorType.AddChild(eMotorModel);
            
            var interval_T = new MaintenanceInterval(
                eMotorType,
                MaintenanceTypeFactory.T_Repair,
                MeasureUnitFactory.WorkHours,
                8000,
                8760,
                12
            );

            var interval_C = new MaintenanceInterval(
                eMotorType,
                MaintenanceTypeFactory.C_Repair,
                MeasureUnitFactory.WorkHours,
                42000,
                43800,
                2
            );

            var interval_K = new MaintenanceInterval(
                eMotorType,
                MaintenanceTypeFactory.K_Repair,
                MeasureUnitFactory.WorkHours,
                130000,
                131400,
                1
            );

            repository.Save(interval_T);
            repository.Save(interval_C);
            repository.Save(interval_K);

            eMotors.AddSpecification(new GroupSpecification(SpecificationFactory.Power));
            eMotors.AddSpecification(new GroupSpecification(SpecificationFactory.RPM));

            repository.Save(eMotors);

            var eMotor = new RepairObject(eMotorModel, "К-401В", DateTime.Now)
            {
                FactoryNumber = "3452",
                InventoryNumber = "123456678"
            };

            eMotor.AddSpecification(new ObjectSpecification(SpecificationFactory.Execution, "1"));

            ElectroMotor = eMotor;
        }
    }
}