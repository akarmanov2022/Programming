using System;
using static ObjectOrientedPractics.Model.Store;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        public PriorityOrder()
        {
            DeliveryDate = DateTime.Now;
            DeliveryInterval = DeliveryTimeInterval.ValueOf(@"09:00 - 11:00");
        }

        /// <summary>
        /// Дата доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Время доставки.
        /// </summary>
        public DeliveryTimeInterval DeliveryInterval { get; set; }
    }
}