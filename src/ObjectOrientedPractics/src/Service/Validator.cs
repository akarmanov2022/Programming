using System;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Service
{
    public static class Validator
    {
        public static void AssertOnStringLength(string str, int maxLength, string propertyName)
        {
            if (str.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} length > {maxLength}");
            }
        }
        
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
                throw new ArgumentException($"{propertyName} < 0: {value}");
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0d)
                throw new ArgumentException($"{propertyName} < 0: {value}");
        }

        public static void AssertOnPositiveValue(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"{propertyName} < {min} or {propertyName} > {max}: {value}");
        }

        public static void AssertOnPositiveValue(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"{propertyName} < {min} or {propertyName} > {max}: {value}");
        }
        
        public static string AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            return Regex.IsMatch(value, "[a-zA-Z0-9]")
                ? value
                : throw new ArgumentException($@"Некорректное значение в свойстве {nameof(propertyName)}!",
                    propertyName);
        }
    }
}