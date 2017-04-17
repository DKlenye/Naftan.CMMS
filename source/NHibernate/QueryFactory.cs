using System.Collections.Generic;
using System.Linq;
using Naftan.CMMS.Domain;
using Naftan.CMMS.Domain.Maintenance;
using Naftan.Infrastructure.NHibernate;
using NHibernate;
using NHibernate.Linq;

namespace Naftan.CMMS.NHibernate
{
    public class QueryFactory:IQueryFactory
    {
        private readonly ISessionProvider provider;
       
        public QueryFactory(ISessionProvider provider)
        {
            this.provider = provider;
        }

        private ISession session => provider.CurrentSession;

        public IEnumerable<LastMaintenance> FindLastMaintenanceByObjectId(int objectId)
        {
            return session.Query<LastMaintenance>().Where(x => x.Object.Id == objectId).ToArray();
        }

        public IEnumerable<MaintenanceInterval> FindMaintenanceIntervalsByObjectId(int objectId)
        {
            throw new System.NotImplementedException();
        }
    }
}
