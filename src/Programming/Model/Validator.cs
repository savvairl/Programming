using System;

namespace Programming.Model
{
    static class Validator
    {
        public static void AssertOnPositiveValue(string propertyName, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть положительным");
            }
        }

        public static void AssertOnPositiveValue(string propertyName, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть положительным");
            }
        }

        public static void AssertValueInRange(string propertyName, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть между {min} и {max}");
            }
        }

        public static void AssertValueInRange(string propertyName, double value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть между {min} и {max}");
            }
        }
    }
}
