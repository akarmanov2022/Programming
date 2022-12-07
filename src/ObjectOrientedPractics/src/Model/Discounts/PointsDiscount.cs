using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts;

/// <summary>
/// Бальная система скидок.
/// </summary>
public class PointsDiscount : IDiscount, IComparable<PointsDiscount>, IComparable, IEquatable<PointsDiscount>
{
    /// <summary>
    /// Максимальный процент скидки.
    /// </summary>
    private const int MaxDiscountPercent = 30;

    /// <summary>
    /// Информация о скидке.
    /// </summary>
    private string _info;

    /// <summary>
    /// Вернуть информацию о скидке.
    /// </summary>
    public string Info
    {
        get => $"Накопительная - {Points} баллов.";
        set => _info = value;
    }

    public bool Active { get; set; } = true;

    /// <summary>
    /// Вернуть количество баллов.
    /// </summary>
    public int Points { get; set; }

    public double Calculate(IEnumerable<Item> items)
    {
        var sum = items.Sum(item => item.Cost);
        var maxDiscount = (int)Math.Ceiling(sum / 100 * MaxDiscountPercent);
        return Points <= maxDiscount
            ? Points
            : maxDiscount;
    }

    public double Apply(IEnumerable<Item> items)
    {
        var points = Points;
        var sum = items.Sum(item => item.Cost);
        var maxDiscount = (int)Math.Ceiling(sum / 100 * MaxDiscountPercent);
        if (points > maxDiscount)
        {
            return Points -= maxDiscount;
        }
        Points = 0;
        return points;
    }

    public void Update(IEnumerable<Item> items)
    {
        Points = (int)(items.Sum(item => item.Cost) / 10);
    }

    public override string ToString()
    {
        return Info;
    }

    public object Clone()
    {
        return new PointsDiscount
        {
            Points = Points,
            Info = Info,
            Active = Active
        };
    }

    public int CompareTo(PointsDiscount other)
    {
        if (ReferenceEquals(this, other)) return 0;
        return ReferenceEquals(null, other) ? 1 : Points.CompareTo(other.Points);
    }

    public int CompareTo(object obj)
    {
        if (ReferenceEquals(null, obj)) return 1;
        if (ReferenceEquals(this, obj)) return 0;
        return obj is PointsDiscount other
            ? CompareTo(other)
            : throw new ArgumentException($"Object must be of type {nameof(PointsDiscount)}");
    }

    public static bool operator <(PointsDiscount left, PointsDiscount right)
    {
        return Comparer<PointsDiscount>.Default.Compare(left, right) < 0;
    }

    public static bool operator >(PointsDiscount left, PointsDiscount right)
    {
        return Comparer<PointsDiscount>.Default.Compare(left, right) > 0;
    }

    public static bool operator <=(PointsDiscount left, PointsDiscount right)
    {
        return Comparer<PointsDiscount>.Default.Compare(left, right) <= 0;
    }

    public static bool operator >=(PointsDiscount left, PointsDiscount right)
    {
        return Comparer<PointsDiscount>.Default.Compare(left, right) >= 0;
    }

    public bool Equals(PointsDiscount other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _info == other._info && Active == other.Active && Points == other.Points;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((PointsDiscount)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = (_info != null ? _info.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ Active.GetHashCode();
            hashCode = (hashCode * 397) ^ Points;
            return hashCode;
        }
    }

    public static bool operator ==(PointsDiscount left, PointsDiscount right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(PointsDiscount left, PointsDiscount right)
    {
        return !Equals(left, right);
    }
}