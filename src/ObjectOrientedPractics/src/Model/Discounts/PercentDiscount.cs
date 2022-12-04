using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts;

/// <summary>
/// Процентная скидка.
/// </summary>
public class PercentDiscount : IDiscount
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

    /// <summary>
    /// Текущий процент скидки.
    /// </summary>
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