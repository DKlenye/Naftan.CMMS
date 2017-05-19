using Naftan.CMMS.Domain;
using Naftan.CMMS.Domain.Specifications;
using Naftan.CMMS.Domain.UserReferences;
using Naftan.Infrastructure.Domain;

namespace Domain.Tests.RepairObjectFactories
{
    public class SpecificationFactory:BaseFactory
    {
        public SpecificationFactory(IRepository repository) : base(repository)
        {
        }

        public static Specification Power { get; private set; }
        public static Specification RPM { get; private set; }
        public static Specification Execution { get; private set; }
        public static Specification EngineVolume { get; private set; }
        public static Specification RegistrationNumber { get; private set; }

        protected override void Build(IRepository repository)
        {
            var execution = new Reference { Name = "Вид исполнения" };
            execution.AddValue(new ReferenceValue { Value = "Открытое" });
            execution.AddValue(new ReferenceValue { Value = "Закрытое" });
            repository.Save(execution);
            
            Power = new Specification
            {
                Name = "Мощность электодвигателя",
                Type = SpecificationType.Decimal,
                Unit = new MeasureUnit { Name = "КВт" }
            };

            RPM = new Specification
            {
                Name = "Частота вращения",
                Type = SpecificationType.Int,
                Unit = new MeasureUnit { Name = "Об/мин" }
            };

            Execution = new Specification
            {
                Name = "Исполнение",
                Type = SpecificationType.Reference,
                Reference = execution
            };

            RegistrationNumber = new Specification
            {
                Name = "Гос. №",
                Type = SpecificationType.String
            };

            EngineVolume = new Specification
            {
                Name = "Объём двигателя, л",
                Type = SpecificationType.Decimal
            };


            repository.Save(Power);
            repository.Save(RPM);
            repository.Save(Execution);
            repository.Save(RegistrationNumber);
            repository.Save(EngineVolume);
        }
    }
}
