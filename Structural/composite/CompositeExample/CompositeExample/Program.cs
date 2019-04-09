using System;

using CompositeImplementation;
using CompositeImplementation.BillExample;

namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Order o = new Order();
            Console.WriteLine(o.OrderDetails());
            Console.ReadLine();
            Client c = new Client();
            c.GetComponent();

            Console.ReadLine();
        }
    }
}
