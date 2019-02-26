using Repository;
using Repository.Contracts;

namespace RepositoryFactory
{
    public class DIToolRepositoryFactory: IRepositoryFactory
    {
       public IUserConfigurationRepository GetUserConfigurationRepository()
        {
            return FakeDiTool<UserConfigurationRepository>.GetInstance();
        }

        public IGridConfigurationRepository GetGridConfigurationRepository()
        {
            return FakeDiTool<GridConfigurationRepository>.GetInstance();
        }
    }
}
