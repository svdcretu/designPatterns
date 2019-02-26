using System.Collections.Generic;

namespace DataContracts
{
    public class UserConfiguration
    {
        public string Guid { get; set; }

        public string Content { get; set; }

        public Dictionary<string, string> MetaData { get; set; }
    }
}
