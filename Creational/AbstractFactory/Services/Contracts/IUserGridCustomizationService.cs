using DataContracts;

namespace Services.Contracts
{
    public interface IUserGridCustomizationService
    {
        UserGridConfiguration GetUserGridConfiguration(string guid);

        void SaveUserGridConfiguration(UserGridConfiguration userGridConfiguration);

        UserConfiguration GetUserConfiguration(string guid);

        void SaveUserConfiguration(UserConfiguration userConfiguration);

        void MigrateData();
    }
}
