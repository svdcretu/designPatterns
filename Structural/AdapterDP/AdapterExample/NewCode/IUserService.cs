using System.Collections.Generic;

namespace AdapterExample.NewCode
{
    public interface IUserService
    {
        User GetUser(int id);

        IList<User> GetUsers();

        void Save(User user);
    }
}
