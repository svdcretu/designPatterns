using System;
using System.Collections.Generic;

using AdapterExample.Legacy;

namespace AdapterExample.NewCode
{
    public class UserService: IUserService
    {
        private readonly UserManager _userManager;

        public UserService(UserManager userManager)
        {
            _userManager = userManager;
        }

        public User GetUser(int id)
        {
            return _userManager.GetUser(id.ToString());
        }

        public IList<User> GetUsers()
        {
            return _userManager.GetUsers();
        }

        public void Save(User user)
        {
            Console.WriteLine("This saves a user into the data base");
        }
    }
}
