using System.Collections.Generic;

namespace AdapterExample.NewCode
{
    public interface ITarget
    {
        int GetData();

        IList<int> GetInformations();
    }
}
