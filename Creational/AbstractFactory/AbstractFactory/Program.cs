using System;
using System.Collections.Generic;

using DataContracts;

using RepositoryFactory;

using Services;
using Services.Contracts;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulateLegacyCodeCalls();
            SimulateNewCodeCalls();

            Console.ReadLine();
        }

        static void SimulateLegacyCodeCalls()
        {
            IRepositoryFactory standardRepositoryFactory = new StandardRepositoryFactory();
            IUserGridCustomizationService gridCustomizationService = new UserGridCustomizationService(standardRepositoryFactory);
            UserGridConfigurationController controller = new UserGridConfigurationController(gridCustomizationService);

            string guid = "123456";
            UserGridConfiguration configuration = controller.GetUserGridConfiguration(guid);
            controller.SaveUserGridConfiguration(configuration);
        }

        static void SimulateNewCodeCalls()
        {
            IRepositoryFactory repositoryFactory = new DIToolRepositoryFactory();
            IUserGridCustomizationService gridCustomizationService = new UserGridCustomizationService(repositoryFactory);
            UserGridConfigurationController controller = new UserGridConfigurationController(gridCustomizationService);

            string guid = "123456";
            UserConfiguration configuration = controller.GetUserConfiguration(guid);
            controller.SaveUserConfiguration(configuration);
        }
    }
}
