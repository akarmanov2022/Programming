using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет объект - заказ.
/// </summary>
public class Order : IEquatable<Order>, ICloneable
{
    /// <summary>
    /// Возвращает идентификатор заказа.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Возвращает дату создания заказа.
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// Возвращает или задает список всех <see cref="Item"/> в заказе.
    /// </summary>
    public List<Item> Items { get; set; } = new List<Item>();

    /// <summary>
    /// Возвращает или задает статуст заказа.
    /// </summary>
    public OrderStatus Status { set; get; }

    /// <summary>
    /// Возвращает или задает адрес доставки.
    /// </summary>
    public Address DeliveryAddress { get; set; } = new Address();

    /// <summary>
    /// Возвращает историю статусов заказа.
    /// </summary>
    public Dictionary<DateTime, OrderStatus> History { get; } = new Dictionary<DateTime, OrderStatus>();

    /// <summary>
    /// Возвращает общую стоимость всех товаров в заказе.
    /// </summary>
    public double Amount
    {
        get { return Items.Sum(item => item.Cost); }
    }

    public double DiscountAmount { get; set; }

    public double TotalAmount => Amount - DiscountAmount;

    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public Order()
    {
        Id = IdGenerator.GetNextId();
        CreateDate = DateTime.Now;
        Status = OrderStatus.New;
    }

    public bool Equals(Order other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id && CreateDate.Equals(other.CreateDate) && Equals(Items, other.Items) &&
               Status == other.Status && Equals(DeliveryAddress, other.DeliveryAddress) &&
               Equals(History, other.History) && DiscountAmount.Equals(other.DiscountAmount);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Order)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Id;
            hashCode = (hashCode * 397) ^ CreateDate.GetHashCode();
            hashCode = (hashCode * 397) ^ (Items != null ? Items.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (int)Status;
            hashCode = (hashCode * 397) ^ (DeliveryAddress != null ? DeliveryAddress.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (History != null ? History.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ DiscountAmount.GetHashCode();
            return hashCode;
        }
    }

    public object Clone()
    {
        var order = new Order
        {
            Id = Id,
            CreateDate = CreateDate,
            Status = Status,
            DeliveryAddress = (Address)DeliveryAddress.Clone(),
            DiscountAmount = DiscountAmount
        };

        foreach (var item in Items)
        {
            order.Items.Add((Item)item.Clone());
        }

        return order;
    }

    public static bool operator ==(Order left, Order right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Order left, Order right)
    {
        return !Equals(left, right);
    }
}