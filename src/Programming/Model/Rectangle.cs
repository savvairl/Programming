namespace Programming.Model
{
    class Rectangle
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
                if (value >= 0)
                {
                    _length = value;
                }
                else
                {
                    throw new System.ArgumentException("Значение длины должно быть положительным");
                }
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
                if (value >= 0)
                {
                    _width = value;
                }
                else
                {
                    throw new System.ArgumentException("Значение ширины должно быть положительным");
                }
            }
        }
    }
}
