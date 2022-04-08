using System;
using static Programming.Service.Validator;

namespace Programming.Model
{
    public class Rectangle
    {

        private static int _allRectanglesCount = 1;

        private double _width;

        private double _length;

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id { get; }

        public Rectangle()
        {
            Id = _allRectanglesCount++;
        }

        public Rectangle(double width, double length, string color, Point2D center)
        {
            Width = width;
            Length = length;
            Color = color;
            Center = center;
            Id = _allRectanglesCount++;
        }

        public double Width
        {
            get => _width;
            set
            {
                AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public double Length
        {
            get => _length;
            set
            {
                AssertOnPositiveValue(value, nameof(Width));
                _length = value;
            }
        }

        public static int AllRectanglesCount => _allRectanglesCount;

        public override string ToString()
        {
            return GetType().Name + " " + Id;
        }

    }
}