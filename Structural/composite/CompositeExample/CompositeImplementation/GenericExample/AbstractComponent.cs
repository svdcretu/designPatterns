using System.Collections.Generic;

namespace CompositeImplementation.GenericExample
{
    public abstract class AbstractComponent : IComponent
    {
        protected string _name;
        protected float _price;

        public AbstractComponent(string name, float price)
        {
            _name = name;
            _price = price;
        }
        
        public virtual string GetName()
        {
            return _name;
        }

        public virtual float GetPrice()
        {
            return _price;
        }

        public virtual bool Add(IComponent component)
        {
            return false;
        }

        public virtual IList<IComponent> GetChildren()
        {
            return null;
        }
    }
}