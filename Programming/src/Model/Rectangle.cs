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

        public Rectangle()
        {
            _id = _counter++;
        }

        public Rectangle(double width, double length, string color)
        {
            Width = width;
            Length = length;
            Color = color;
            _id = _counter++;
        }

        public double Width
        {
            get => _width;
            set => _width = value < 0 ? throw new ArgumentException($"Width < 0: {value}") : value;
        }

        public double Length
        {
            get => _length;
            set => _length = value < 0 ? throw new ArgumentException($"Length < 0: {value}") : value;
        }

        public override string ToString()
        {
            return GetType().Name + " " + _id;
        }
    }
}