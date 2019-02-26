using System;

using Repository.Contracts;

namespace RepositoryFactory
{
    public interface IRepositoryFactory
    {
        IUserConfigurationRepository GetUserConfigurationRepository();

        IGridConfigurationRepository GetGridConfigurationRepository();
    }
}
