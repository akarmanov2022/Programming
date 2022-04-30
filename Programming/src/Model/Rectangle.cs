using System;
using static Programming.Service.Validator;

namespace Programming.Model
{
    public class Rectangle
    {
        private static int _allRectanglesCount = 1;

        private int _width;

        private int _height;

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id { get; }

        public Rectangle()
        {
            Id = _allRectanglesCount++;
        }

        public Rectangle(int width, int height, string color, Point2D center)
        {
            Width = width;
            Height = height;
            Color = color;
            Center = center;
            Id = _allRectanglesCount++;
        }

        public int Width
        {
            get => _width;
            set
            {
                AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                AssertOnPositiveValue(value, nameof(Width));
                _height = value;
            }
        }

        public static int AllRectanglesCount => _allRectanglesCount;

        public override string ToString()
        {
            return $"{Id}: " +
                   $"({nameof(Center.X)}={Center.X}; " +
                   $"{nameof(Center.Y)}={Center.Y}; " +
                   $"{nameof(Width).Remove(1)}={Width}; " +
                   $"{nameof(Height).Remove(1)}={Height})";
        }
    }
}