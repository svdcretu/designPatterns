using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryLibrary
{
    public class UserGridConfiguration
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<string> Columns { get; set; }

        public List<string> Filters { get; set; }
    }
}
