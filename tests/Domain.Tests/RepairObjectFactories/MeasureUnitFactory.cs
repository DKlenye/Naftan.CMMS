using Naftan.CMMS.Domain;
using Naftan.Infrastructure.Domain;

namespace Domain.Tests.RepairObjectFactories
{
    public class MeasureUnitFactory:BaseFactory
    {
        public MeasureUnitFactory(IRepository repository) : base(repository)
        {
        }

        public static MeasureUnit WorkHours { get; private set; }
        public static MeasureUnit Km { get; private set; }

        protected override void Build(IRepository repository)
        {
            WorkHours = new MeasureUnit()
            {
                Name = "Время",
                Description = "Часы наработки",
                Designation = "ч"

            };

            Km = new MeasureUnit
            {
                Name = "Расстояние",
                Description = "Пробег",
                Designation = "км"
            };

            repository.Save(WorkHours);
            repository.Save(Km);

        }
    }
}
