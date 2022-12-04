using System.Collections.Generic;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Интерфейс для реализации скидок.
/// </summary>
public interface IDiscount
{
    /// <summary>
    /// Информация о скидке.
    /// </summary>
    string Info { get; }

    /// <summary>
    /// Рассчитать скидку для набора товаров.
    /// </summary>
    /// <param name="items">Набор товаров.</param>
    /// <returns>Сумма скидки.</returns>
    double Calculate(List<Item> items);

    /// <summary>
    /// Применить скидку к набору товаров.
    /// </summary>
    /// <param name="items">Набор товаров.</param>
    /// <returns>Скидка.</returns>
    double Apply(List<Item> items);

    /// <summary>
    /// Обновить скидку.
    /// </summary>
    /// <param name="items">Набор товаров.</param>
    void Update(List<Item> items);
}