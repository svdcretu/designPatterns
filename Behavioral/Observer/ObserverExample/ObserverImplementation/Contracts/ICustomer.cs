namespace ObserverImplementation.Contracts
{
    /// <summary>Observer contract.</summary>
    public interface ICustomer
    {
        void Update(IPromotion promotion);
    }
}