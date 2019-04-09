namespace CompositeImplementation.BillExample
{
    public class Order
    {
        private IProduct _product;

        public Order()
        {
            BuildOrder();
        }

        private void BuildOrder()
        {
            _product = new Product  { Name = "City Car", Price = 10000 };
            var door = new Product  { Name = "Single Dor", Price = 100 };
            var wheel = new Product { Name = "Wheel", Price = 200 };
            var engine = new Product { Name = "Electic Engine", Price = 7000 };
            _product.AddItem(door);
            _product.AddItem(wheel);
            _product.AddItem(engine);

            var enginePart1 = new Product { Name = "Engine Part1", Price = 3400 }; 
            var enginePart2 = new Product { Name = "Engine Part2", Price = 3600 };
            engine.AddItem(enginePart1);
            engine.AddItem(enginePart2);
        }
        public string OrderDetails()
        {
            return _product.Description();
        }
    }
}
