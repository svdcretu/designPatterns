using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeImplementation.BillExample
{
    public class Product: IProduct
    {
        private readonly IList<IProduct> _items;
        public string Name { get; set; }
        public float Price { get; set; }

        public Product()
        {
            _items = new List<IProduct>();
        }
        public string Description()
        {
            var sb = new StringBuilder($" Product: {Name} has a total price of {Price} $");
            sb.Append(Environment.NewLine);
            if (HasChildren())
            {
                sb.Append(Environment.NewLine);
                sb.Append("   And is composed from the following items: ");
                for (int i = 0; i < _items.Count; i++)
                {
                    var product = _items[i];
                    sb.Append(Environment.NewLine);
                    sb.Append($"   => {i + 1} - {product.Description()}");
                }
            }

            return sb.ToString();
        }

        public bool HasChildren()
        {
            return _items.Count > 0;
        }
        public void AddItem(IProduct product)
        {
            _items.Add(product);
        }
    }
}
