using System;

namespace MusicPlaylist.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
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
                                              int value)
        {
            if (!(value >= min && value <= max))
                throw new System.ArgumentException(
                    $"Значение поля {propertyName} должно быть между {min} и {max}");
        }
    }
}
