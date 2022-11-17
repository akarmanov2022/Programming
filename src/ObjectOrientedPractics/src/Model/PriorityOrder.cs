using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string _deliveryTime;
        

        public PriorityOrder(DateTime deliveryDate, string deliveryTime)
        {
            _deliveryDate = deliveryDate;
            _deliveryTime = deliveryTime;
        }
    }
}