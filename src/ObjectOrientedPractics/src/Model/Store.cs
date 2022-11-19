using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект - магазин, который хранит в себе списки <see cref="Item"/> и <see cref="Customer"/>.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Возвращает или задает список объектов типа <see cref="Item"/>
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Возвращает или задает список объектов типа <see cref="Customer"/>.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public static List<DeliveryTimeInterval> DeliveryTimeIntervals { get; } =
            new List<DeliveryTimeInterval>
            {
                new DeliveryTimeInterval("09:00 - 11:00"),
                new DeliveryTimeInterval("11:00 - 13:00"),
                new DeliveryTimeInterval("13:00 - 15:00"),
                new DeliveryTimeInterval("15:00 - 17:00"),
                new DeliveryTimeInterval("17:00 - 19:00")
            };

        public class DeliveryTimeInterval
        {
            private static readonly Regex Regex =
                new Regex(@"\d{2}:\d{2} - \d{2}:\d{2}");

            public string Value { set; get; }

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
                    return DeliveryTimeIntervals.Find(interval => interval.Value.Equals(value));
                }

                throw new ArgumentException("Argument not valid!");
            }
        }
    }
}