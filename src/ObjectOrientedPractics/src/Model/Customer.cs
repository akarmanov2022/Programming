using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет объект "Покупатель".
/// </summary>
public class Customer : ICloneable, IEquatable<Customer>
{
    private const int MaxLengthFullname = 200;

    /// <summary>
    /// Хранит полное имя <see cref="Customer"/>.
    /// </summary>
    private string _fullname;

    public bool IsPriority { set; get; }

    /// <summary>
    /// Возвращает значение идентификатора.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Возвращает или задает значение полного имени. Длина строки не должна превышать <see cref="MaxLengthFullname"/>/>
    /// </summary>
    public string Fullname
    {
        get
        {
            if (string.IsNullOrWhiteSpace(_fullname)) _fullname = $"{LastName} {FirstName} {FatherName}";
            return _fullname;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, MaxLengthFullname, nameof(Fullname));
            _fullname = value;
        }
    }

    /// <summary>
    /// Возвращает или задает значение фамилии.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Возвращает или задает значение имени.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Возвращает или задает значение отчества.
    /// </summary>
    public string FatherName { get; set; }

    /// <summary>
    ///  Возвращает или задает адрес <see cref="Customer"/>.
    /// </summary>
    public Address Address { get; private set; }

    /// <summary>
    /// Возвращает корзину покупателя.
    /// </summary>
    public Cart Cart { get; private set; }

    /// <summary>
    /// Возвращает список всех заказов покупателя.
    /// </summary>
    public List<Order> Orders { private set; get; } = new();

    public List<IDiscount> Discounts { get; private set; } = new();

    /// <summary>
    /// Конструктор по умолчанию. 
    /// </summary>
    public Customer()
    {
        Id = IdGenerator.GetNextId();
        Address = new Address();
        Cart = new Cart();
    }

    public override string ToString()
    {
        return Fullname;
    }

    public object Clone()
    {
        return new Customer
        {
            Id = Id,
            Fullname = Fullname,
            LastName = LastName,
            FirstName = FirstName,
            FatherName = FatherName,
            Address = Address,
            Cart = Cart,
            Orders = Orders,
            Discounts = Discounts
        };
    }

    public bool Equals(Customer other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _fullname == other._fullname && IsPriority == other.IsPriority && Id == other.Id &&
               LastName == other.LastName && FirstName == other.FirstName && FatherName == other.FatherName &&
               Equals(Address, other.Address) && Equals(Cart, other.Cart) && Equals(Orders, other.Orders) &&
               Equals(Discounts, other.Discounts);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Customer)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = (_fullname != null ? _fullname.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ IsPriority.GetHashCode();
            hashCode = (hashCode * 397) ^ Id;
            hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (FirstName != null ? FirstName.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (FatherName != null ? FatherName.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (Cart != null ? Cart.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (Orders != null ? Orders.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (Discounts != null ? Discounts.GetHashCode() : 0);
            return hashCode;
        }
    }

    public static bool operator ==(Customer left, Customer right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Customer left, Customer right)
    {
        return !Equals(left, right);
    }
}