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

    /// <summary>
    /// Вернуть информацию о скидке.
    /// </summary>
    public string Info => $"Накопительная - {Points} баллов.";

    /// <summary>
    /// Вернуть количество баллов.
    /// </summary>
    public int Points { get; private set; }

    public double Calculate(List<Item> items)
    {
        var sum = items.Sum(item => item.Cost);
        var maxDiscount = (int)Math.Ceiling(sum / 100 * MaxDiscountPercent);
        return Points <= maxDiscount
            ? Points
            : maxDiscount;
    }

    public double Apply(List<Item> items)
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

    public void Update(List<Item> items)
    {
        Points = (int)(items.Sum(item => item.Cost) / 10);
    }
}