
using System.Collections.Generic;
using System.Text;

namespace CompositeImplementation.GenericExample
{
    public class Composite: AbstractComponent
    {
        private IList<IComponent> _components;
        public Composite(string name, float price) : base(name, price)
        {
            _components = new List<IComponent>();
        }
        public override bool Add(IComponent component)
        {
            _components.Add(component);
            return true;
        }
        public override IList<IComponent> GetChildren()
        {
            return _components;
        }
        public override float GetPrice()
        {
            var children = GetChildren();
            float price = _price;
            foreach (IComponent child in children) { price += child.GetPrice(); }
            return price;
        }
        public override string GetName()
        {
            var children = GetChildren();
            var sb = new StringBuilder(_name);
            foreach (IComponent child in children) { sb.Append("; => "); sb.Append(child.GetName()); }
            return sb.ToString();
        }
    }
}
