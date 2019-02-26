using Repository;
using Repository.Contracts;

namespace RepositoryFactory
{
    public class StandardRepositoryFactory: IRepositoryFactory
    {
        public IUserConfigurationRepository GetUserConfigurationRepository()
        {
            return new UserConfigurationRepository();
        }

        public IGridConfigurationRepository GetGridConfigurationRepository()
        {
            return new GridConfigurationRepository();
        }
    }
}
