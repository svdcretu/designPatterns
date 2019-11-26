using System;

using ObserverImplementation.Models;

namespace ObserverImplementation.ConcretePromotions
{
    public class ChristmasPromotion : Promotion
    {
        private readonly DateTime c_firstChristmasDay = new DateTime(2019, 12, 24, 0, 0, 0);

        private readonly DateTime c_lastChristmasDay = new DateTime(2019, 12, 27, 23, 59, 59);

        public ChristmasPromotion()
        {
            promotionModel = new PromotionModel
            {
                Name = "Christmas 2019"
            };
        }

        protected override void AddNewProductToPromotion(double oldPrice, double newPrice, string description)
        {
            _newProduct = new PromotionProduct
            {
                NewPrice = newPrice,
                OldPrice = oldPrice,
                Name = description
            };
        }

        protected override void EndPromotion(DateTime endDate)
        {
            promotionModel.DateEnd = endDate > c_lastChristmasDay ? endDate : c_lastChristmasDay;
        }

        protected override void StartPromotion(int discount, string promotionDescription, DateTime startDate, DateTime endDate)
        {
            promotionModel.Description = promotionDescription;
            promotionModel.Discount = discount;
            promotionModel.StartDate = startDate < c_firstChristmasDay ? startDate : c_firstChristmasDay;
            promotionModel.DateEnd = endDate > c_lastChristmasDay ? endDate : c_lastChristmasDay;
        }
    }
}