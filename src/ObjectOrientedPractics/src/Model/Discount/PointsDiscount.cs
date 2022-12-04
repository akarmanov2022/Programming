using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discount;

public class PointsDiscount : IDiscount
{
    private const int MaxDiscountPercent = 30;

    public string Info => $"Накопительная - {Points} баллов.";
    public int Points { get; private set; }

    public double Calculate(List<Item> items)
    {
        var sum = items.Sum(item => item.Cost);
        var maxPoints = (int)sum / 100 * MaxDiscountPercent;
        return Points > maxPoints ? MaxDiscountPercent : Points / sum * 100;
    }

    public double Apply(List<Item> items)
    {
        var points = Points;
        Points = 0;
        var sum = items.Sum(item => item.Cost);
        return points / sum * 100;
    }

    public void Update(List<Item> items)
    {
        Points += (int)items.Sum(item => item.Cost) / 10;
    }
}