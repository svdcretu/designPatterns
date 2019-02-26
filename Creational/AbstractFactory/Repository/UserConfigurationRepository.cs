using System;
using System.Collections.Generic;
using System.Text;

using DataContracts;

using Repository.Contracts;

namespace Repository
{
    public class UserConfigurationRepository: IUserConfigurationRepository
    {
        public UserConfiguration GetById(string guid)
        {
            Console.WriteLine($"For {guid} gets the UserConfiguration from MongoDB");

            return new UserConfiguration { Guid = guid};
        }

        public void Save(UserConfiguration userConfiguration)
        {
            Console.WriteLine($"For {userConfiguration.Guid} saves the UserConfiguration into MongoDB"); 
        }
    }
}
