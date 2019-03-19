using System;
using System.Collections.Generic;

namespace AdapterExample.NewCode
{
    public class DisplayUserService: IDisplayUser
    {
        public void DisplayUser(User user)
        {
            Console.WriteLine();
            Console.WriteLine("*** Display User Info ***");
            Console.WriteLine($" User with id = {user.Id} has name {user.Name} and address {user.Address} ");
            Console.WriteLine("***");
            Console.WriteLine();
        }

        public void DisplayUsers(IList<User> users)
        {
            Console.WriteLine("*** User List Info ***");
            foreach (User user in users)
            {
                DisplayUser(user);
            }
            Console.WriteLine();
        }
    }
}
