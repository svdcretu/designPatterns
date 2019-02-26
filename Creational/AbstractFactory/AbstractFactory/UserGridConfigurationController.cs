using DataContracts;

using Services.Contracts;

namespace AbstractFactory
{
    public class UserGridConfigurationController
    {

        private readonly IUserGridCustomizationService _userGridCustomizationService;

        public UserGridConfigurationController(IUserGridCustomizationService userGridCustomizationService)
        {
            _userGridCustomizationService = userGridCustomizationService;
        }

        public UserGridConfiguration GetUserGridConfiguration(string guid)
        {
            return _userGridCustomizationService.GetUserGridConfiguration(guid);
        }

        public UserConfiguration GetUserConfiguration(string guid)
        {
            return _userGridCustomizationService.GetUserConfiguration(guid);
        }

        public void SaveUserGridConfiguration(UserGridConfiguration configuration)
        {
            _userGridCustomizationService.SaveUserGridConfiguration(configuration);
        }

        public void SaveUserConfiguration(UserConfiguration configuration)
        {
            _userGridCustomizationService.SaveUserConfiguration(configuration);
        }
    }
}
