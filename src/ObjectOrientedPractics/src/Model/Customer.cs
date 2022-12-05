using System.Collections.Generic;
using System.Text.Json.Serialization;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет объект "Покупатель".
/// </summary>
public class Customer
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
    public int Id { get; }

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
    public Address Address { get; set; }

    /// <summary>
    /// Возвращает корзину покупателя.
    /// </summary>
    public Cart Cart { get; }

    /// <summary>
    /// Возвращает список всех заказов покупателя.
    /// </summary>
    public List<Order> Orders { set; get; } = new();

    public List<IDiscount> Discounts { get; } = new();

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
}