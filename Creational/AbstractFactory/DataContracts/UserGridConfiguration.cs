using System;
using System.Collections.Generic;
using System.Text;

namespace DataContracts
{
    public class UserGridConfiguration
    {
        public string Guid { get; set; }

        public string Name { get; set; }

        public List<string> Columns { get; set; }

        public List<string> Filters { get; set; }
    }
}
