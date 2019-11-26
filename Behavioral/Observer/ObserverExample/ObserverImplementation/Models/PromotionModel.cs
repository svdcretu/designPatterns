using System;

namespace ObserverImplementation.Models
{
    public class PromotionModel
    {
        public DateTime DateEnd { get; set; }

        public string Description { get; set; }

        public int Discount { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public NotificationType NotificationType { get; set; }
    }
}