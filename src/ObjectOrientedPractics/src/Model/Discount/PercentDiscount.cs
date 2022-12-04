using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discount;

public class PercentDiscount : IDiscount
{
    private const int MaxDiscount = 10;

    public PercentDiscount(Category category)
    {
        Category = category;
    }

    public Category Category { get; set; }

    public string Info => $"Процентная «{Category}» - {CurrentDiscountPercent}%";

    public int CurrentDiscountPercent { get; set; } = 1;

    public double Calculate(List<Item> items)
    {
        var itemsByCategory = items.Where(item => item.Category == Category).ToList();
        if (!itemsByCategory.Any())
        {
            return 0;
        }
        var sum = itemsByCategory.Sum(item => item.Cost);
        if (sum >= 1000 && CurrentDiscountPercent <= MaxDiscount)
        {
            CurrentDiscountPercent++;
        }
        return sum / CurrentDiscountPercent;
    }

    public double Apply(List<Item> items)
    {
        var currentDiscount = CurrentDiscountPercent;
        CurrentDiscountPercent = 0;
        var itemsByCategory = items.Where(item => item.Category == Category).ToList();
        return itemsByCategory.Sum(item => item.Cost) / currentDiscount;
    }

    public void Update(List<Item> items)
    {
        var itemsByCategory = items.Where(item => item.Category == Category).ToList();
        var sum = itemsByCategory.Sum(item => item.Cost);
        if (sum >= 1000 && CurrentDiscountPercent <= MaxDiscount)
        {
            CurrentDiscountPercent++;
        }
    }
}