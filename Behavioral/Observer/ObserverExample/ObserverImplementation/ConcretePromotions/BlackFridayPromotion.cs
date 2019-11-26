using System;

using ObserverImplementation.Models;

namespace ObserverImplementation.ConcretePromotions
{
    public class BlackFridayPromotion : Promotion
    {
        public BlackFridayPromotion()
        {
            promotionModel = new PromotionModel
            {
                Name = "Black Friday 2019"
            };
        }

        protected override void AddNewProductToPromotion(double oldPrice, double newPrice, string description)
        {
            _newProduct = new PromotionProduct
            {
                Name = description,
                NewPrice = newPrice,
                OldPrice = oldPrice
            };
        }

        protected override void EndPromotion(DateTime endDate)
        {
            promotionModel.DateEnd = endDate;
        }

        protected override void StartPromotion(int discount, string promotionDescription, DateTime startDate, DateTime endDate)
        {
            promotionModel.Description = $"Black Friday 2019 with discount starting from {discount}% . {promotionDescription}";
            promotionModel.StartDate = startDate;
            promotionModel.DateEnd = endDate;
            promotionModel.Discount = discount;
        }
    }
}