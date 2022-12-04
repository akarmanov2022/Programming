using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discount;

public class PercentDiscount : IDiscount
{
    private const int MaxPercentDiscount = 10;

    public PercentDiscount(Category category)
    {
        Category = category;
    }

    public Category Category { get; set; }

    public double PurchaseAmount { get; set; }

    public string Info => $"Процентная «{Category}» - {CurrentPercentDiscount}%";

    public int CurrentPercentDiscount { get; set; } = 1;

    public double Calculate(List<Item> items)
    {
        var sum = items.Where(item => item.Category == Category)
            .Sum(item => item.Cost);
        return sum / CurrentPercentDiscount;
    }

    public double Apply(List<Item> items)
    {
        var currentDiscount = CurrentPercentDiscount;
        CurrentPercentDiscount = 0;
        var sum = items.Where(item => item.Category == Category)
            .Sum(item => item.Cost);
        return sum / currentDiscount;
    }

    public void Update(List<Item> items)
    {
        var sum = items.Where(item => item.Category == Category)
            .Sum(item => item.Cost);
        PurchaseAmount += sum;
        var newDiscountPercent = (int)(PurchaseAmount / 1000);
        if (newDiscountPercent <= MaxPercentDiscount)
        {
            CurrentPercentDiscount = newDiscountPercent;
        }
    }
}