using System;
using Naftan.CMMS.Domain;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.CMMS.Domain.RepairObjects;
using Naftan.CMMS.Domain.Specifications;
using Naftan.Infrastructure.Domain;

namespace Domain.Tests.RepairObjectFactories
{
    public class CarFactory:BaseFactory
    {
        public CarFactory(IRepository repository) : base(repository)
        {
        }

        public static RepairObject Car { get; private set; }

        protected override void Build(IRepository repository)
        {
            new SpecificationFactory(repository);
            new MaintenanceTypeFactory(repository);
            new MeasureUnitFactory(repository);
            
            var ts = new RepairObjectGroup { Name = "Транспортные средства" };
            
            ts.AddSpecification(new GroupSpecification(SpecificationFactory.RegistrationNumber));
            ts.AddSpecification(new GroupSpecification(SpecificationFactory.EngineVolume));

            var cars = new RepairObjectGroup { Name = "Легковые автомобили" };
            var engine_1_8 = new RepairObjectGroup { Name = "Объём двигателя от 1,8 л до 3,5 л" };

            cars.AddChild(engine_1_8);
            ts.AddChild(cars);

            repository.Save(ts);
            repository.Save(cars);
            repository.Save(engine_1_8);

            //Интервал ТО-1 10 ткм, либо 1 раз в 2 года
            var Interval_TO1 = new MaintenanceInterval(
                engine_1_8,
                MaintenanceTypeFactory.TO1_Repair,
                TimePeriod.Year, 2,
                MeasureUnitFactory.Km, 10000
            );

            //Интервал ТО-2 20 ткм
            var Interval_TO2 = new MaintenanceInterval(
                engine_1_8,
                MaintenanceTypeFactory.TO2_Repair,
                MeasureUnitFactory.Km,
                20000
            );

            repository.Save(Interval_TO1);
            repository.Save(Interval_TO2);

            Car = new RepairObject(engine_1_8, "999", DateTime.Now);
            repository.Save(Car);
        }
    }
}