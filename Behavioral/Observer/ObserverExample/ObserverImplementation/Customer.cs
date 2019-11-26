using System;
using System.Transactions;

using ObserverImplementation.Contracts;
using ObserverImplementation.Models;

namespace ObserverImplementation
{
    public class Customer: ICustomer
    {
        private readonly string c_name;
        public Customer(string name)
        {
            c_name = name;
        }

        public void Update(IPromotion promotion)
        {
            Console.WriteLine();
            Console.WriteLine($"{c_name} received the following notification:");
            switch (promotion.PromotionModel.NotificationType)
            {
                case NotificationType.PromotionStart:
                    Console.WriteLine(
                        $"{promotion.PromotionModel.Name} will start on {promotion.PromotionModel.StartDate} will end on {promotion.PromotionModel.DateEnd} and will have discount rate {promotion.PromotionModel.Discount}%");
                    Console.WriteLine($"See more details: {promotion.PromotionModel.Description} !");
                    break;
                case NotificationType.PromotionEnd:
                    Console.WriteLine($"The {promotion.PromotionModel.Name} has a new end date = {promotion.PromotionModel.DateEnd};");
                    break;
                case NotificationType.NewProductAdded:
                    Console.WriteLine($"New product for {promotion.PromotionModel.Name}:");
                    Console.WriteLine($"{promotion.NewProduct.Name} costs now {promotion.NewProduct.NewPrice}$ reduced from {promotion.NewProduct.OldPrice}$;");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine();
            Console.WriteLine("*********************");

        }
    }
}
