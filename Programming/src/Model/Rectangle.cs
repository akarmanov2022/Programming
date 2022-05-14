using System.Drawing;
using Programming.Service;

namespace Programming.Model
{
    public class Rectangle
    {
        public static readonly Color DefaultRectangleColor = Color.FromArgb(127, 127, 255, 127);

        public static readonly Color CollisionRectangleColor = Color.FromArgb(127, 255, 127, 127);
        
        private static int _allRectanglesCount;

        private int _width;

        private int _height;

        public Color Color { get; set; }

        public Point2D Center { get; set; }

        public int Id { get; }

        public Rectangle()
        {
            Id = _allRectanglesCount++;
            Color = DefaultRectangleColor;
        }

        public Rectangle(int width, int height, Point2D center)
        {
            Width = width;
            Height = height;
            Color = DefaultRectangleColor;
            Center = center;
            Id = _allRectanglesCount++;
        }

        public Rectangle(Rectangle rectangle)
        {
            Width = rectangle.Width;                 
            Height = rectangle.Height;                  
            Color = rectangle.Color;                 
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);                  
            Id = rectangle.Id;              
        }

        public int Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _height = value;
            }
        }

        public static int AllRectanglesCount => _allRectanglesCount;

        public override string ToString()
        {
            return $"{Id + 1}: " +
                   $"({nameof(Center.X)}={Center.X}; " +
                   $"{nameof(Center.Y)}={Center.Y}; " +
                   $"{nameof(Width).Remove(1)}={Width}; " +
                   $"{nameof(Height).Remove(1)}={Height})";
        }

        protected bool Equals(Rectangle other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Rectangle) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}