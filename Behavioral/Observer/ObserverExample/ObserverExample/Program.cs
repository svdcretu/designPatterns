using System;
using System.Collections.Generic;

using ObserverImplementation;
using ObserverImplementation.ConcretePromotions;
using ObserverImplementation.Contracts;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var blackFriday = new BlackFridayPromotion();
            var christmas = new ChristmasPromotion();
            IList<ICustomer> customers = Program.GetCustomers();
            foreach (ICustomer customer in customers)
            {
                christmas.Attach(customer);
                blackFriday.Attach(customer);
            }

            Console.WriteLine("---------------- CHRISTMAS PROMOTION -----------------");
            christmas.Start(25, "Christmas Sales", new DateTime(2019,12,21), new DateTime(2019,12,29));
            christmas.AddNewProduct(1500,1100, "Dell i5 Laptop");
            christmas.Detach(customers[0]);
            christmas.End(new DateTime(2019,12,31));
            Console.WriteLine("--------------- ****  ------------------");

            Console.WriteLine();
            Console.WriteLine("---------------- CHRISTMAS PROMOTION -----------------");
            blackFriday.Start(20, "Best offers ever!", new DateTime(2019, 11, 29), new DateTime(2019, 11, 29,23,59,59));
            blackFriday.Detach(customers[1]);
            blackFriday.AddNewProduct(1100, 799, "Iphone X");
            blackFriday.End(new DateTime(2019, 12, 1));
            Console.WriteLine("--------------- ****  ------------------");

            Console.ReadLine();
        }

        static IList<IPromotion> GetPromotions()
        {
            var promotions = new List<IPromotion>
            {
                new BlackFridayPromotion(),
                new ChristmasPromotion()
            };

            return promotions;
        }

        static IList<ICustomer> GetCustomers()
        {
            var customers = new List<ICustomer>
            {
                new Customer("John"),
                new Customer("David")
            };

            return customers;
        }
    }
}
