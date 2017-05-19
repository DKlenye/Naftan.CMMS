using Naftan.CMMS.Domain.Maintenance;
using Naftan.Infrastructure.Domain;

namespace Domain.Tests.RepairObjectFactories
{
    public class MaintenanceTypeFactory : BaseFactory
    {
        public MaintenanceTypeFactory(IRepository repository) : base(repository)
        {
        }

        public static MaintenanceType T_Repair { get; private set; }
        public static MaintenanceType C_Repair { get; private set; }
        public static MaintenanceType K_Repair { get; private set; }
        public static MaintenanceType TO1_Repair { get; private set; }
        public static MaintenanceType TO2_Repair { get; private set; }
        public static MaintenanceType CO_Repair { get; private set; }
        public static MaintenanceType TR_Repair { get; private set; }

        protected override void Build(IRepository repository)
        {
            T_Repair = new MaintenanceType {Name = "Текущий ремонт", Designation = "Т"};
            C_Repair = new MaintenanceType {Name = "Средний ремонт", Designation = "C"};
            K_Repair = new MaintenanceType {Name = "Капитальный ремонт", Designation = "K"};
            TO1_Repair = new MaintenanceType {Name = "Первое техническое обслуживание", Designation = "ТО1"};
            TO2_Repair = new MaintenanceType {Name = "Второе техническое обслуживание", Designation = "ТО2"};
            CO_Repair = new MaintenanceType {Name = "Средний ремонт", Designation = "СР"};
            TR_Repair = new MaintenanceType {Name = "Текущий ремонт", Designation = "ТР"};

            repository.Save(T_Repair);
            repository.Save(C_Repair);
            repository.Save(K_Repair);
            repository.Save(TO1_Repair);
            repository.Save(TO2_Repair);
            repository.Save(CO_Repair);
            repository.Save(TR_Repair);
        }
    }
}