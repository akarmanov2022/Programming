using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет объект - Корзина.
/// </summary>
public class Cart : ICloneable, IEquatable<Cart>
{   
    /// <summary>
    /// Возвращает или задает список <see cref="Item"/>.
    /// </summary>
    public List<Item> Items { get; set; } = new List<Item>();

    /// <summary>
    /// Возвращает общую стоимость всех <see cref="Item"/> в корзине.
    /// </summary>
    public double Amount
    {
        get
        {
            return Items?.Sum(item => item.Cost) ?? 0D;
        }
    }

    public object Clone()
    {
        return new Cart
        {
            Items = Items?.Select(item => (Item)item.Clone()).ToList()
        };
    }

    public bool Equals(Cart other)
    {
        if (ReferenceEquals(null, other)) return false;
        return ReferenceEquals(this, other) || Equals(Items, other.Items);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Cart)obj);
    }

    public override int GetHashCode()
    {
        return (Items != null ? Items.GetHashCode() : 0);
    }

    public static bool operator ==(Cart left, Cart right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Cart left, Cart right)
    {
        return !Equals(left, right);
    }
}