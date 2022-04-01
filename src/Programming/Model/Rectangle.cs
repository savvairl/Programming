using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        public Rectangle()
        {

        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public string Color { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение длины должно быть положительным");
                }

                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение ширины должно быть положительным");
                }

                _width = value;
            }
        }
    }
}
