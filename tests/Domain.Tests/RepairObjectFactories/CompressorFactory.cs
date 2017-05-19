using Naftan.Infrastructure.Domain;

namespace Domain.Tests.RepairObjectFactories
{
    public class CompressorFactory:BaseFactory
    {
        public CompressorFactory(IRepository repository) : base(repository)
        {
        }

        protected override void Build(IRepository repository)
        {
            throw new System.NotImplementedException();
        }
    }
}
