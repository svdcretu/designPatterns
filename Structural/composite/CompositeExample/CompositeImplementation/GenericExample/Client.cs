using System;

using CompositeImplementation.GenericExample;

namespace CompositeImplementation
{
    public class Client
    {
        private IComponent _mainComponent;

        public Client()
        {
            _mainComponent = new Composite(string.Empty, 0);
            IComponent leaf1 = new Composite("Leaf 1", 10);
            IComponent leaf2 = new Composite("Leaf 2", 20);
            IComponent leaf3 = new Composite("Leaf 3", 30);
            _mainComponent.Add(leaf1);
            _mainComponent.Add(leaf2);
            _mainComponent.Add(leaf3);

            IComponent composite = new Composite("Composite 1", 1);
            IComponent leaf4 = new Composite("Leaf 4", 40);
            IComponent leaf5 = new Composite("Leaf 5", 50);
            IComponent leaf6 = new Composite("Leaf 6", 60);
            composite.Add(leaf4);
            composite.Add(leaf5);
            composite.Add(leaf6);
            _mainComponent.Add(composite);
        }

        public IComponent GetComponent()
        {
            Console.WriteLine(_mainComponent.GetName());
            Console.WriteLine(_mainComponent.GetPrice());
            return _mainComponent;
        }
    }
}