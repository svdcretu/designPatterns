using System;
using System.Collections.Generic;

using DataContracts;

using Repository.Contracts;

namespace Repository
{
    public class GridConfigurationRepository : IGridConfigurationRepository
    {
        public UserGridConfiguration GetById(string guid)
        {
            Console.WriteLine($"For {guid} gets the UserGridConfiguration from SQL Server");

            return new UserGridConfiguration {Guid =  guid};
        }

        public void Save(UserGridConfiguration userGridConfiguration)
        {
            Console.WriteLine($"For {userGridConfiguration.Guid} saves the UserGridConfiguration into SQL Server");
        }

        public List<UserGridConfiguration> GetAll()
        {
            Console.WriteLine("Gets the entire list of UserGridConfiguration from sql server");
            return new List<UserGridConfiguration>();
        }
    }
}
