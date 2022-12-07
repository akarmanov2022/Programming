using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Этот класс представляет собой сущность "Адрес".
/// </summary>
public class Address : IEquatable<Address>, IComparable<Address>, IComparable, ICloneable
{
    /// <summary>
    /// Почтовый индекс.
    /// </summary>
    private int _index;

    /// <summary>
    /// Страна/Регион.
    /// </summary>
    private string _country;

    /// <summary>
    /// Город (населенный пункт), строка, не более 50 символов.
    /// </summary>
    private string _city;

    /// <summary>
    /// Улица, строка, не более 100 символов.
    /// </summary>
    private string _street;

    /// <summary>
    /// Номер дома, строка, не более 10 символов.
    /// </summary>
    private string _building;

    /// <summary>
    /// Номер квартиры/помещения, не более 10 символов.
    /// </summary>
    private string _apartment;

    /// <summary>
    /// Возвращает почтовый индекс <see cref="Address"/>. Максимум 6 символов. 
    /// </summary>
    public int Index
    {
        get => _index;
        set
        {
            ValueValidator.AssertOnPositiveValue(value, 0, 999_999, nameof(Index));
            _index = value;
        }
    }

    /// <summary>
    /// Возвращает или задает название страны. Максимум 50 символов.
    /// </summary>
    public string Country
    {
        get => _country ?? "";
        set
        {
            ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
            _country = value;
        }
    }

    /// <summary>
    /// Возвращает или задает название города. Максимум 50 символов.
    /// </summary>
    public string City
    {
        get => _city ?? "";
        set
        {
            ValueValidator.AssertStringOnLength(value, 50, nameof(City));
            _city = value;
        }
    }

    /// <summary>
    /// Возвращает или задает название улицы. Максимум 100 символов.
    /// </summary>
    public string Street
    {
        get => _street ?? "";
        set
        {
            ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
            _street = value;
        }
    }

    /// <summary>
    /// Возвращает или задает номер дома. Максимум 10 символов.
    /// </summary>
    public string Building
    {
        get => _building ?? "";
        set
        {
            ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
            _building = value;
        }
    }

    /// <summary>
    /// Возвращает или задает номер квартиры. Максимум 10 символов.
    /// </summary>
    public string Apartment
    {
        get => _apartment ?? "";
        set
        {
            ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
            _apartment = value;
        }
    }

    public override string ToString()
    {
        return string.Join(", ", Index.ToString(), Country, City, Street, Building, Apartment);
    }

    public bool Equals(Address other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _index == other._index && _country == other._country && _city == other._city &&
               _street == other._street && _building == other._building && _apartment == other._apartment;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Address)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _index;
            hashCode = (hashCode * 397) ^ (_country != null ? _country.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (_city != null ? _city.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (_street != null ? _street.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (_building != null ? _building.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ (_apartment != null ? _apartment.GetHashCode() : 0);
            return hashCode;
        }
    }

    public object Clone()
    {
        return new Address
        {
            Index = Index,
            Country = Country,
            City = City,
            Street = Street,
            Building = Building,
            Apartment = Apartment
        };
    }

    public static bool operator ==(Address left, Address right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Address left, Address right)
    {
        return !Equals(left, right);
    }

    public int CompareTo(Address other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var indexComparison = _index.CompareTo(other._index);
        if (indexComparison != 0) return indexComparison;
        var countryComparison = string.Compare(_country, other._country, StringComparison.Ordinal);
        if (countryComparison != 0) return countryComparison;
        var cityComparison = string.Compare(_city, other._city, StringComparison.Ordinal);
        if (cityComparison != 0) return cityComparison;
        var streetComparison = string.Compare(_street, other._street, StringComparison.Ordinal);
        if (streetComparison != 0) return streetComparison;
        var buildingComparison = string.Compare(_building, other._building, StringComparison.Ordinal);
        return buildingComparison != 0
            ? buildingComparison
            : string.Compare(_apartment, other._apartment, StringComparison.Ordinal);
    }

    public int CompareTo(object obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is Address other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(Address)}");
    }

    public static bool operator <(Address left, Address right)
    {
        return Comparer<Address>.Default.Compare(left, right) < 0;
    }

    public static bool operator >(Address left, Address right)
    {
        return Comparer<Address>.Default.Compare(left, right) > 0;
    }

    public static bool operator <=(Address left, Address right)
    {
        return Comparer<Address>.Default.Compare(left, right) <= 0;
    }

    public static bool operator >=(Address left, Address right)
    {
        return Comparer<Address>.Default.Compare(left, right) >= 0;
    }
}