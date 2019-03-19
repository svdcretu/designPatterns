using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExample.NewCode
{
    public interface IDisplayUser
    {
        void DisplayUser(User user);

        void DisplayUsers(IList<User> users);
    }
}
