using System;

namespace ObjectOrientedPractics.Service;

/// <summary>
/// Статический класс для валидации значений.
/// </summary>
public static class ValueValidator
{
    /// <summary>
    /// Утверждает, что длина строки находится в пределах максимального значения. 
    /// </summary>
    /// <param name="str">Исходная строка.</param>
    /// <param name="maxLength">Значение максимальной длины.</param>
    /// <param name="propertyName">Имя свойства.</param>
    /// <exception cref="ArgumentException">Возникает, если длина строки больше максимального значения.</exception>
    public static void AssertStringOnLength(string str, int maxLength, string propertyName)
    {
        if (str.Length > maxLength)
        {
            throw new ArgumentException($"Длина строки {propertyName} не может превышать {maxLength} символов.");
        }
    }

    /// <summary>
    /// Утверждает, что число с плавающей запятой находится в пределах минимального и максимального значений. 
    /// </summary>
    /// <param name="value">Исходное значение.</param>
    /// <param name="min">Минимальное значение.</param>
    /// <param name="max">Максимальное значение.</param>
    /// <param name="propertyName">Имя свойства.</param>
    /// <exception cref="ArgumentException">Возникает, если значение находится вне пределов минимального и максимального значений.</exception>
    public static void AssertOnPositiveValue(double value, double min, double max, string propertyName)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException($"Значение свойства {propertyName} должно быть в пределах от {min} до {max}.");
        }
    }
        
    /// <summary>
    /// Утверждает, что целое число находится в пределах минимального и максимального значений. 
    /// </summary>
    /// <param name="value">Исходное значение.</param>
    /// <param name="min">Минимальное значение.</param>
    /// <param name="max">Максимальное значение.</param>
    /// <param name="propertyName">Имя свойства.</param>
    /// <exception cref="ArgumentException">Возникает, если значение находится вне пределов минимального и максимального значений.</exception>
    public static void AssertOnPositiveValue(int value, double min, double max, string propertyName)
    {
        if (value < min || value > max)
        {
            throw new ArgumentException($"Значение свойства {propertyName} должно быть в пределах от {min} до {max}.");
        }
    }
}