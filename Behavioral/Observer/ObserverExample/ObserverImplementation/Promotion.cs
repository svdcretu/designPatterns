// ------------------------------------------------------------------------------
//     <copyright file="Promotion.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using ObserverImplementation.Contracts;
using ObserverImplementation.Models;

namespace ObserverImplementation
{
    public abstract class Promotion : IPromotion
    {
        private readonly List<ICustomer> _customers;
        
        protected PromotionModel promotionModel;

        protected PromotionProduct _newProduct;

        protected Promotion()
        {
            _customers = new List<ICustomer>();
        }

        public PromotionModel PromotionModel => promotionModel;

        public PromotionProduct NewProduct => _newProduct;

        public void Attach(ICustomer customer)
        {
            _customers.Add(customer);
        }

        public void Detach(ICustomer customer)
        {
            _customers.Remove(customer);
        }

        public void Start(int discount, string promotionDescription, DateTime startDate, DateTime endDate)
        {
            promotionModel.NotificationType = NotificationType.PromotionStart;
            StartPromotion(discount, promotionDescription, startDate, endDate);
            Notify();
            promotionModel.NotificationType = NotificationType.None;
        }

        public void End(DateTime endDate)
        {
            promotionModel.NotificationType = NotificationType.PromotionEnd;
            EndPromotion(endDate);
            Notify();
            promotionModel.NotificationType = NotificationType.None;
        }

        public void AddNewProduct(double oldPrice, double newPrice, string description)
        {
            promotionModel.NotificationType = NotificationType.NewProductAdded;
            AddNewProductToPromotion(oldPrice, newPrice, description);
            Notify();
            promotionModel.NotificationType = NotificationType.None;
        }

        protected abstract void EndPromotion(DateTime endDate);

        protected abstract void AddNewProductToPromotion(double oldPrice, double newPrice, string description);

        protected abstract void StartPromotion(int discount, string promotionDescription, DateTime startDate, DateTime endDate);

        public void Notify()
        {
            _customers.ForEach(x => x.Update(this));
        }
    }
}