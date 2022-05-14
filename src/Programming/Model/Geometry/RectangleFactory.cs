using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Предоставляет методы для создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <param name="canvasWidth">Ширина элемента размещения.</param>
        /// <param name="canvasHeight">Высота элемента размещения.</param>
        /// <returns>Возвращает объект <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Center = new Point2D(_random.Next(Margin, canvasWidth - rectangle.Width - Margin),
                                           _random.Next(Margin, canvasHeight - rectangle.Height - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <returns>Возвращает объект <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(1, 500), _random.Next(1, 500));
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}
