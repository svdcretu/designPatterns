namespace CompositeImplementation.BillExample
{
    public interface IProduct
    {
        string Description();
        bool HasChildren();
        void AddItem(IProduct product);
    }
}
