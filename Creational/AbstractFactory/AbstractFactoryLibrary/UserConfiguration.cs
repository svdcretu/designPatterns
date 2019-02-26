using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryLibrary
{
    public class UserConfiguration
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public Dictionary<string, string> MetaData { get; set; }
    }
}
