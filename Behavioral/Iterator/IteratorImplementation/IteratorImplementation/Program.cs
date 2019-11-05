using System;

using IteratorLibrary;

namespace IteratorImplementation
{
    class Program
    {
        static IIterator<UserModel> CreateUserModelIterator()
        {
            IAggregator<UserModel> aggregator = new Aggregator<UserModel>();
            IIterator<UserModel> iterator = aggregator.CreateIterator();
            aggregator[0] = new UserModel
            {
                Id = 1,
                Name = "John",
                Country = "USA"
            };

            aggregator[1] = new UserModel
            {
                Id = 2,
                Name = "Maria",
                Country = "Romania"
            };

            aggregator[2] = new UserModel
            {
                Id = 3,
                Name = "Juan",
                Country = "Mexico"
            };

            return iterator;
        }

        static void Main(string[] args)
        {
            
            IIterator<UserModel> iterator = Program.CreateUserModelIterator();
            UserModel userModel = iterator.CurrentItem();
            Console.WriteLine($"Current Item: {userModel.GetInfo()}");
            userModel = iterator.NextItem();
            Console.WriteLine($"NextItem Item: {userModel.GetInfo()}");
            userModel = iterator.NextItem();
            Console.WriteLine($"NextItem Item: {userModel.GetInfo()}");
            userModel = iterator.NextItem();
            Console.WriteLine($"NextItem Item: {userModel.GetInfo()}");
            userModel = iterator.PreviousItem();
            Console.WriteLine($"PreviousItem Item: {userModel.GetInfo()}");

            iterator.Add(
                new UserModel
                {
                    Id = 4,
                    Name = "Igor",
                    Country = "Rusia"
                });
            userModel = iterator.LastItem();
            Console.WriteLine($"Last Item: {userModel.GetInfo()}");

            userModel = iterator.First();
            Console.WriteLine($"First Item: {userModel.GetInfo()}");

            Console.ReadLine();
        }
    }
}