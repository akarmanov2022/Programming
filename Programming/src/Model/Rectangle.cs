using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private static int _counter = 1;

        private readonly int _id;

        private double _width;
        private double _length;

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public Rectangle()
        {
            _id = _counter++;   
        }

        public Rectangle(double width, double length, string color, Point2D center)
        {
            Width = width;
            Length = length;
            Color = color;
            Center = center;
            _id = _counter++;
        }

        public double Width
        {
            get => _width;
            set => _width = Validator.AssertOnPositiveValue(value, nameof(Width));
        }

        public double Length
        {
            get => _length;
            set => _length = Validator.AssertOnPositiveValue(value, nameof(Width));
        }

        public override string ToString()
        {
            return GetType().Name + " " + _id;
        }
    }
}