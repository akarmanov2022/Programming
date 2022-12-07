using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts;

/// <summary>
/// Бальная система скидок.
/// </summary>
public class PointsDiscount : IDiscount
{
    /// <summary>
    /// Максимальный процент скидки.
    /// </summary>
    private const int MaxDiscountPercent = 30;

    private string _info;

    /// <summary>
    /// Вернуть информацию о скидке.
    /// </summary>
    public string Info
    {
        get => $"Накопительная - {Points} баллов.";
        set => _info = value;
    }

    /// <summary>
    /// Вернуть количество баллов.
    /// </summary>
    public int Points { get; private set; }

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
}