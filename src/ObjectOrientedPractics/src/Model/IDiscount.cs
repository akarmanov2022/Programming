using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Интерфейс для реализации скидок.
/// </summary>
public interface IDiscount : ICloneable
{
    /// <summary>
    /// Информация о скидке.
    /// </summary>
    string Info { get; }

    public bool Active { get; set; }

    /// <summary>
    /// Рассчитать скидку для набора товаров.
    /// </summary>
    /// <param name="items">Набор товаров.</param>
    /// <returns>Сумма скидки.</returns>
    double Calculate(IEnumerable<Item> items);

    /// <summary>
    /// Применить скидку к набору товаров.
    /// </summary>
    /// <param name="items">Набор товаров.</param>
    /// <returns>Скидка.</returns>
    double Apply(IEnumerable<Item> items);

    /// <summary>
    /// Обновить скидку.
    /// </summary>
    /// <param name="items">Набор товаров.</param>
    void Update(IEnumerable<Item> items);
}