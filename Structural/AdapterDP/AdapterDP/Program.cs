using System;
using System.Collections.Generic;

using AdapterExample;
using AdapterExample.Legacy;
using AdapterExample.NewCode;

namespace AdapterDP
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = Program.GetUserService();
            IDisplayUser displayUser = Program.GetDisplayUserService();

            User user = userService.GetUser(25);
            displayUser.DisplayUser(user);
            IList<User> userList = userService.GetUsers();
            displayUser.DisplayUsers(userList);
            userService.Save(user);

            Console.ReadLine();
        }

        static IUserService GetUserService()
        {
            return new UserService(new UserManager());
        }

        static IDisplayUser GetDisplayUserService()
        {
            return new DisplayUserService();
        }
    }
}
