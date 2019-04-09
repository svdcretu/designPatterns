using System.Collections.Generic;

namespace CompositeImplementation.GenericExample
{
    public interface IComponent
    {
        string GetName();

        float GetPrice();

        bool Add(IComponent component);

        IList<IComponent> GetChildren();
    }
}
