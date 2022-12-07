using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Товар.
/// </summary>
public class Item : IComparable<Item>, IComparable, IEquatable<Item>, ICloneable
{
    /// <summary>
    /// Хранит имя товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    private string _info;

    /// <summary>
    /// Хранит цену товара.
    /// </summary>
    private double _cost;

    /// <summary>
    /// Возвращает идентификатор.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Возвращает или задает значение имени. Длина строки не должна превышать 200./>
    /// </summary>
    public string Name
    {
        get
        {
            if (string.IsNullOrWhiteSpace(_name)) _name = $"{CarBrand} {CarModel}".Trim();
            return _name;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает или задает значение поля информации. Длина строки не должна превышать 1000./>
    /// </summary>
    public string Info
    {
        get => _info ?? "";
        set
        {
            ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
            _info = value;
        }
    }

    /// <summary>
    /// Возвращает или задает значение цены. Длина строки должна быть в пределах от 0 до 100000./>
    /// </summary>
    public double Cost
    {
        get => _cost;
        set
        {
            ValueValidator.AssertOnPositiveValue(value, 0, 100_000, nameof(Name));
            _cost = value;
        }
    }

    public string CarBrand { set; get; }

    public string CarModel { set; get; }

    /// <summary>
    /// Возвращает или задает <see cref="Category"/>.
    /// </summary>
    public Category? Category { set; get; }

    /// <summary>
    /// Создает экземпляр объекта <see cref="Item"/>.
    /// </summary>
    /// <param name="name">Название товара.</param>
    /// <param name="info">Информация о товаре.</param>
    /// <param name="cost">Цена товара.</param>
    public Item(string name, string info, double cost)
    {
        Id = IdGenerator.GetNextId();
        Name = name;
        Info = info;
        Cost = cost;
    }

    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public Item()
    {
        Id = IdGenerator.GetNextId();
    }

    public override string ToString()
    {
        return string.IsNullOrWhiteSpace(Name)
            ? $"{nameof(Item)}-{Id + 1}"
            : Name;
    }

    public object Clone()
    {
        return new Item
        {
            _name = _name,
            _info = _info,
            _cost = _cost,
            Id = Id,
            CarBrand = CarBrand,
            CarModel = CarModel,
            Category = Category
        };
    }

    public bool Equals(Item other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _name == other._name && _info == other._info && _cost.Equals(other._cost) && Id == other.Id &&
               CarBrand == other.CarBrand && CarModel == other.CarModel && Category == other.Category;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Item)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = (_name != null ? _name.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (_info != null ? _info.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _cost.GetHashCode();
            hashCode = (hashCode * 397) ^ Id;
            hashCode = (hashCode * 397) ^ (CarBrand != null ? CarBrand.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (CarModel != null ? CarModel.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ Category.GetHashCode();
            return hashCode;
        }
    }

    public static bool operator ==(Item left, Item right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Item left, Item right)
    {
        return !Equals(left, right);
    }

    public int CompareTo(Item other)
    {
        if (ReferenceEquals(this, other)) return 0;
        return ReferenceEquals(null, other) ? 1 : _cost.CompareTo(other._cost);
    }

    public int CompareTo(object obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is Item other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Item)}");
    }

    public static bool operator <(Item left, Item right)
    {
        return Comparer<Item>.Default.Compare(left, right) < 0;
    }

    public static bool operator >(Item left, Item right)
    {
        return Comparer<Item>.Default.Compare(left, right) > 0;
    }

    public static bool operator <=(Item left, Item right)
    {
        return Comparer<Item>.Default.Compare(left, right) <= 0;
    }

    public static bool operator >=(Item left, Item right)
    {
        return Comparer<Item>.Default.Compare(left, right) >= 0;
    }
}