using System.Collections.Generic;
using System.Linq;

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
}