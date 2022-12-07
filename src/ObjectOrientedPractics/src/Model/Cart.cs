using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Представляет объект - Корзина.
/// </summary>
public class Cart
{   
    /// <summary>
    /// Возвращает или задает список <see cref="Item"/>.
    /// </summary>
    public List<Item> Items { get; set; } = new List<Item>();

    /// <summary>
    /// Возвращает общую стоимость всех <see cref="Item"/> в корзине.
    /// </summary>
    public double Amount
    {
        get
        {
            return Items?.Sum(item => item.Cost) ?? 0D;
        }
    }
}