using System.Collections.Generic;

using DataContracts;

using Repository.Contracts;

using RepositoryFactory;

using Services.Contracts;

namespace Services
{
    public class UserGridCustomizationService : IUserGridCustomizationService
    { 
        private readonly IUserConfigurationRepository _userConfigurationRepository;
        private readonly IGridConfigurationRepository _gridConfigurationRepository;

        public UserGridCustomizationService(IRepositoryFactory repositoryFactory)
        {
            _userConfigurationRepository = repositoryFactory.GetUserConfigurationRepository();
            _gridConfigurationRepository = repositoryFactory.GetGridConfigurationRepository();
        }

        public UserGridConfiguration GetUserGridConfiguration(string guid)
        {
            return _gridConfigurationRepository.GetById(guid);
        }

        public void SaveUserGridConfiguration(UserGridConfiguration userGridConfiguration)
        {
            _gridConfigurationRepository.Save(userGridConfiguration);
        }

        public UserConfiguration GetUserConfiguration(string guid)
        {
            return _userConfigurationRepository.GetById(guid);
        }

        public void SaveUserConfiguration(UserConfiguration userConfiguration)
        {
            _userConfigurationRepository.Save(userConfiguration); 
        }

        public void MigrateData()
        {
            List<UserGridConfiguration> gridConfiguration =  _gridConfigurationRepository.GetAll();
            foreach (UserGridConfiguration userGridConfiguration in gridConfiguration)
            {
                
                var userConfiguration = new UserConfiguration
                {
                    Guid = userGridConfiguration.Guid,
                    Content = userGridConfiguration.ToString()
                };

                _userConfigurationRepository.Save(userConfiguration);
            }
            
        }
    }
}
