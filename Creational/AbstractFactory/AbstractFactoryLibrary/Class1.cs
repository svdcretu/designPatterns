using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace AbstractFactoryLibrary
{
    public class Product
    {
    }
    public class Order
    {
        public List<Product> Products { get; set; }

        public string UserName { get; set; }

        public double TotalAmount { get; set; }

        public string OrderDescription { get; set; }
    }

    public class Invoice
    {
        public List<Product> Products { get; set; }

        public string UserName { get; set; }

        public double TotalAmount { get; set; }

        public string InvoiceDescription { get; set; }

        public string PaymentMethod { get; set; }

        public string DeliveryAddress { get; set; }

    }
}
