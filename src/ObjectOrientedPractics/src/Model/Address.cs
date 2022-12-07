using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Этот класс представляет собой сущность "Адрес".
/// </summary>
public class Address : ICloneable
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
}