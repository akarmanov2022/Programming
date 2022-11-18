using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        public PriorityOrder(DateTime deliveryDate, string deliveryTime)
        {
            DeliveryDate = deliveryDate;
            DeliveryInterval = DeliveryTimeInterval.ValueOf(deliveryTime);
        }

        /// <summary>
        /// Дата доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Время доставки.
        /// </summary>
        public DeliveryTimeInterval DeliveryInterval { get; set; }

        public class DeliveryTimeInterval
        {
            private static readonly Regex Regex = 
                new Regex(@"\d{2}:\d{2} - \d{2}:\d{2}");

            private string Value { get; }

            public DeliveryTimeInterval(string value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return Value;
            }

            public static DeliveryTimeInterval ValueOf(string value)
            {
                if (Regex.IsMatch(value))
                {
                    return new DeliveryTimeInterval(value);
                }

                throw new ArgumentException("Argument not valid!");
            }
        }
    }
}