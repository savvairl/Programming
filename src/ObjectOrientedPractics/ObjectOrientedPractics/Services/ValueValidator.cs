using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что число положительное.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        public static void AssertOnPositiveValue(string propertyName, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"Значение {propertyName} должен быть больше нуля");
            }
        }

        /// <summary>
        /// Проверяет, что количество символов строки меньше определённого числа.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="maxLength">Максимальное значение.</param>
        /// <param name="value">Строка.</param>
        public static void AssertStringOnLength(string propertyName,
                                                int maxLength,
                                                string value)
        {
            if (value.Length > maxLength)
                throw new ArgumentException(
                    $"{propertyName} должен быть меньше {maxLength} символов");
        }

        /// <summary>
        /// Проверяет, что количество цифр в числе равно заданному.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество цифр числа не равно заданному.</exception>
        public static void AssertIntOnLength(string propertyName,
                                             int maxLength,
                                             int value)
        {
            if (value.ToString().Length != maxLength)
                throw new ArgumentException(
                    $"{propertyName} должен быть меньше {maxLength} символов");
        }

        /// <summary>
        /// Проверяет, что количество символов в строке находится в нужном диапазоне.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество символов строки не входит в диапазон.</exception>
        public static void AssertCountSymbolsInRange(string propertyName,
                                                     int min,
                                                     int max,
                                                     string value)
        {
            if (!(value.Length >= min && value.Length <= max))
                throw new ArgumentException(
                    $"Число символов в поле {propertyName} должно быть от {min} до {max}");
        }

        /// <summary>
        /// Проверяет, что число находится в нужном диапазоне.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число не входит в диапазон.</exception>
        public static void AssertValueInRange(string propertyName,
                                              int min,
                                              int max,
                                              double value)
        {
            if (!(value >= min && value <= max))
                throw new ArgumentException(
                    $"Значение поля {propertyName} должно быть между {min} и {max}");
        }
    }
}
