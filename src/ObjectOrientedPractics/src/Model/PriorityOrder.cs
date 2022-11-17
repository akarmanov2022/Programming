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
        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private DeliveryTimeInterval _deliveryInterval;


        public PriorityOrder(DateTime deliveryDate, string deliveryTime)
        {
            _deliveryDate = deliveryDate;
            _deliveryInterval = DeliveryTimeInterval.CreateFrom(deliveryTime);
        }

        public class DeliveryTimeInterval
        {
            private static readonly Regex Regex = new Regex("\\d{2}:\\d{2} - \\d{2}:\\d{2}");

            public string Value { set; get; }

            private DeliveryTimeInterval(string value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return Value;
            }

            public static DeliveryTimeInterval CreateFrom(string value)
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