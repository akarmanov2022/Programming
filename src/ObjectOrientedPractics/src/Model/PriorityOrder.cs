using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет заказ приоритетного обслуживания.
/// </summary>
public class PriorityOrder : Order
{
    public static List<DeliveryTimeInterval> DeliveryTimeIntervals { get; } =
        new()
        {
            new DeliveryTimeInterval("09:00 - 11:00"),
            new DeliveryTimeInterval("11:00 - 13:00"),
            new DeliveryTimeInterval("13:00 - 15:00"),
            new DeliveryTimeInterval("15:00 - 17:00"),
            new DeliveryTimeInterval("17:00 - 19:00")
        };

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