using System;

using ObserverImplementation.Models;

namespace ObserverImplementation.Contracts
{
    /// <summary>
    /// The `Subject` contact
    /// </summary>
    public interface IPromotion
    {
        PromotionModel PromotionModel { get; }

        PromotionProduct NewProduct { get; }

        void Attach(ICustomer customer);

        void Detach(ICustomer customer);

        void Notify();

        void Start(int discount, string promotionDescription, DateTime startDate, DateTime endDate);

        void End(DateTime endDate);

        void AddNewProduct(double oldPrice, double newPrice, string description);
    }
}
