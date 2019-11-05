using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorImplementation
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string GetInfo()
        {
            string userInfo = $"{Id}. {Name} from {Country}";

            return userInfo;
        }
    }
}
