using System;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число. </param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string propertyName, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string propertyName, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть положительным");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(string propertyName, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть между {min} и {max}");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(string propertyName, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {propertyName} должно быть между {min} и {max}");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка состоит не только из
        /// букв английского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string propertyName, string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"Значение {propertyName} должно содержать только буквы");
                }
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из цифр.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка состоит не только из цифр.</exception>
        public static void AssertValueContainsOnlyDigits(string propertyName, string value)
        {
            if (!long.TryParse(value, out long number))
            {
                throw new System.ArgumentException($"Значение {propertyName} должно состоять только из цифр");
            }
        }

        /// <summary>
        /// Проверяет, что в строке 11 символов.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если в строке не 11 символов.</exception>
        public static void AssertNumberContainsElevenDigits(string propertyName, string value)
        {
            if (value.Length != 11)
            {
                throw new System.ArgumentException($"Значение {propertyName} должно содержать 11 символов");
            }
        }
    }
}
