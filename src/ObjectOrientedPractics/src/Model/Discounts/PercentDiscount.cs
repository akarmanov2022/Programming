using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts;

/// <summary>
/// Процентная скидка.
/// </summary>
public class PercentDiscount : IDiscount, IComparable<PercentDiscount>, IComparable, IEquatable<PercentDiscount>
{
    /// <summary>
    /// Максимальный процент скидки.
    /// </summary>
    private const int MaxPercentDiscount = 10;

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="category">Категория товара.</param>
    public PercentDiscount(Category category)
    {
        Category = category;
    }

    /// <summary>
    /// Вернуть или установить категорию товара.
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Вернуть или установить стоимость покупки.
    /// </summary>
    public double PurchaseAmount { get; set; }

    /// <summary>
    /// Вернуть информацию о скидке.
    /// </summary>
    public string Info => $"Процентная «{Category}» - {CurrentPercentDiscount}%";

    public bool Active { get; set; } = true;

    /// <summary>
    /// Текущий процент скидки.
    /// </summary>
    public int CurrentPercentDiscount { get; set; } = 1;

    public double Calculate(IEnumerable<Item> items)
    {
        var sum = items.Where(item => item.Category == Category)
            .Sum(item => item.Cost);
        return sum / 100 * CurrentPercentDiscount;
    }

    public double Apply(IEnumerable<Item> items)
    {
        var currentDiscount = CurrentPercentDiscount;
        var sum = items.Where(item => item.Category == Category)
            .Sum(item => item.Cost);
        return sum / 100 * currentDiscount;
    }

    public void Update(IEnumerable<Item> items)
    {
        var sum = items.Where(item => item.Category == Category)
            .Sum(item => item.Cost);
        PurchaseAmount += sum;
        if (PurchaseAmount / 1000 >= CurrentPercentDiscount && CurrentPercentDiscount <= MaxPercentDiscount)
        {
            CurrentPercentDiscount++;
        }
    }
    public override string ToString()
    {
        return Info;
    }

    public object Clone()
    {
        return new PercentDiscount(Category)
        {
            PurchaseAmount = PurchaseAmount,
            CurrentPercentDiscount = CurrentPercentDiscount
        };
    }

    public int CompareTo(PercentDiscount other)
    {
        if (ReferenceEquals(this, other)) return 0;
        return ReferenceEquals(null, other) ? 1 : CurrentPercentDiscount.CompareTo(other.CurrentPercentDiscount);
    }

    public int CompareTo(object obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is PercentDiscount other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(PercentDiscount)}");
    }

    public static bool operator <(PercentDiscount left, PercentDiscount right)
    {
        return Comparer<PercentDiscount>.Default.Compare(left, right) < 0;
    }

    public static bool operator >(PercentDiscount left, PercentDiscount right)
    {
        return Comparer<PercentDiscount>.Default.Compare(left, right) > 0;
    }

    public static bool operator <=(PercentDiscount left, PercentDiscount right)
    {
        return Comparer<PercentDiscount>.Default.Compare(left, right) <= 0;
    }

    public static bool operator >=(PercentDiscount left, PercentDiscount right)
    {
        return Comparer<PercentDiscount>.Default.Compare(left, right) >= 0;
    }

    public bool Equals(PercentDiscount other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Category == other.Category && PurchaseAmount.Equals(other.PurchaseAmount) && Active == other.Active &&
               CurrentPercentDiscount == other.CurrentPercentDiscount;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((PercentDiscount)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = (int)Category;
            hashCode = (hashCode * 397) ^ PurchaseAmount.GetHashCode();
            hashCode = (hashCode * 397) ^ Active.GetHashCode();
            hashCode = (hashCode * 397) ^ CurrentPercentDiscount;
            return hashCode;
        }
    }

    public static bool operator ==(PercentDiscount left, PercentDiscount right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(PercentDiscount left, PercentDiscount right)
    {
        return !Equals(left, right);
    }
}