using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет объект - магазин, который хранит в себе списки <see cref="Item"/> и <see cref="Customer"/>.
/// </summary>
public class Store : ICloneable, IEquatable<Store>
{
    /// <summary>
    /// Возвращает или задает список объектов типа <see cref="Item"/>
    /// </summary>
    public List<Item> Items { get; set; } = new();

    /// <summary>
    /// Возвращает или задает список объектов типа <see cref="Customer"/>.
    /// </summary>
    public List<Customer> Customers { get; set; } = new();

    public object Clone()
    {
        var store = new Store();
        foreach (var item in Items)
        {
            store.Items.Add((Item)item.Clone());
        }

        foreach (var customer in Customers)
        {
            store.Customers.Add((Customer)customer.Clone());
        }

        return store;
    }

    public bool Equals(Store other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Equals(Items, other.Items) && Equals(Customers, other.Customers);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Store)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return ((Items != null ? Items.GetHashCode() : 0) * 397) ^
                   (Customers != null ? Customers.GetHashCode() : 0);
        }
    }

    public static bool operator ==(Store left, Store right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Store left, Store right)
    {
        return !Equals(left, right);
    }
}