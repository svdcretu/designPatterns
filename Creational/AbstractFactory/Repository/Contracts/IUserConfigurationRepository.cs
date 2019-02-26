using DataContracts;

namespace Repository.Contracts
{
    public interface IUserConfigurationRepository
    {
        UserConfiguration GetById(string guid);

        void Save(UserConfiguration userConfiguration);
    }
}
