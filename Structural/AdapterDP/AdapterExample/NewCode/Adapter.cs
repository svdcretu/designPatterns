using System.Collections.Generic;
using System.Linq;

using AdapterExample.Legacy;

namespace AdapterExample.NewCode
{
    public class Adapter: ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public int GetData()
        {
            return _adaptee.GetData();
        }

        public IList<int> GetInformations()
        {
            return _adaptee.GetInformations().ToList();
        }
    }
}
