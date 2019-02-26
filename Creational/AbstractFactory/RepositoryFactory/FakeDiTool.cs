using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryFactory
{
    public static class FakeDiTool<T> where T : new()
    {
        public static T GetInstance()
        {
            return new T();
        }
    }
}
