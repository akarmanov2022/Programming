using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Programming.Service
{
    /// <summary>
    /// Валидация ввода.
    /// </summary>
    public static class Validator
    {
        public static readonly Color BackColorSuccess = Color.White;

        public static readonly Color BackColorException = Color.LightPink;
        
        /// <summary>
        /// Проверка на положительное число.
        /// </summary>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно быть положительным.");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно быть положительным.");
            }
        }

        public static void AssertOnPositiveValue(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно быть в диапазоне от {min} до {max}.");
            }
        }

        public static void AssertOnPositiveValue(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно быть в диапазоне от {min} до {max}.");
            }
        }
        
        /// <summary>
        /// Проверка на содержание в строке только букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Возвращает true, если строка содержит только буквы.</returns>
        /// <exception cref="ArgumentException">Возникает, если строка содержит не только буквы.</exception>
        public static string AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"Значение свойства {propertyName} должно содержать только буквы.");
            }

            return value;
        }
    }
}