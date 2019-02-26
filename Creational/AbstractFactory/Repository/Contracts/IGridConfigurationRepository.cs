using System.Collections.Generic;

using DataContracts;

namespace Repository.Contracts
{
    public interface IGridConfigurationRepository
    {
        List<UserGridConfiguration> GetAll();

        UserGridConfiguration GetById(string guid);

        void Save(UserGridConfiguration userGridConfiguration);
    }
}
