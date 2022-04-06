using System;

namespace Programming.Service
{
    public static class Validator
    {
        public static int AssertOnPositiveValue(int value, string propertyName)
        {
            return value >= 0
                ? value 
                : throw new ArgumentException($"{propertyName} < 0: {value}");
        }
        
        public static double AssertOnPositiveValue(double value, string propertyName)
        {
            return value >= 0d
                ? value 
                : throw new ArgumentException($"{propertyName} < 0: {value}");
        }
        
        public static int AssertOnPositiveValue(int value, int min, int max, string propertyName)
        {
            return value >= min && value <= max
                ? value 
                : throw new ArgumentException($"{propertyName} < {min} or {propertyName} > {max}: {value}");
        }
        
        public static double AssertOnPositiveValue(double value, double min, double max, string propertyName)
        {
            return value >= min && value <= max
                ? value 
                : throw new ArgumentException($"{propertyName} < {min} or {propertyName} > {max}: {value}");
        }
    }
}