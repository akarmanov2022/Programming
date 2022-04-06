using System;
using Programming.Service;

namespace Programming.Model
{
    public class Rectangle
    {
        private static int _allRectanglesCount = 1;

        private readonly int _id;

        private double _width;
        private double _length;

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public Rectangle()
        {
            _id = _allRectanglesCount++;   
        }

        public Rectangle(double width, double length, string color, Point2D center)
        {
            Width = width;
            Length = length;
            Color = color;
            Center = center;
            _id = _allRectanglesCount++;
        }

        public int Id => _id;

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

        public static int AllRectanglesCount => _allRectanglesCount;

        public override string ToString()
        {
            return GetType().Name + " " + _id;
        }
    }
}