using System;
using System.Drawing;

namespace Programming.Service
{
    public static class Validator
    {
        public static readonly Color BackColorSuccess = Color.White;

        public static readonly Color BackColorException = Color.LightPink;
        
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{propertyName} < 0: {value}");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0d)
            {
                throw new ArgumentException($"{propertyName} < 0: {value}");
            }
        }

        public static void AssertOnPositiveValue(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} < {min} or {propertyName} > {max}: {value}");
            }
        }

        public static void AssertOnPositiveValue(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} < {min} or {propertyName} > {max}: {value}");
            }
        }
    }
}