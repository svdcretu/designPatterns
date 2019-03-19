using System.Collections.Generic;


namespace AdapterExample.Legacy
{
    public class UserManager
    {
        public User GetUser(string userId)
        {
            List<User> users = GetUsers();
            foreach (User user in users)
            {
                if (user.Id.ToString().Equals(userId))
                {
                    return user;
                }
            }

            return null;
        }

        public List<User> GetUsers()
        {
            List<User> results = new List<User>
            {
                new User
                {
                    Id = 15,
                    Address = "Some Address",
                    Name = "Some Name"
                },
                new User
                {
                    Id = 25,
                    Address = "Another Address",
                    Name = "Another Name"
                }
            };

            return results;
        }

        public Role GetRole(string roleId)
        {
            return new Role();
        }

        public List<Role> GetRoles()
        {
            return new List<Role>();
        }

        public double GetUserBalanceByMonth(string userId, int month, int year)
        {
            return 27.27;
        }

    }
}
