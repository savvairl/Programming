using System;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {
        private const int margin = 15;

        private static Random _random = new Random();

        public static Rectangle Randomize(int canvasWidth, int canvasHeight)
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Center = new Point2D(_random.Next(margin, canvasWidth - rectangle.Width - margin),
                                           _random.Next(margin, canvasHeight - rectangle.Height - margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }

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
