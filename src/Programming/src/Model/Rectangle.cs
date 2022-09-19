using System.Drawing;
using Programming.Service;

namespace Programming.Model
{
    /// <summary>
    /// Представлят прямоугольник. Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Значение цвета по умолчанию.
        /// </summary>
        public static readonly Color DefaultRectangleColor = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Значение цвета при пересечении.
        /// </summary>
        public static readonly Color CollisionRectangleColor = Color.FromArgb(127, 255, 127, 127);
        
        /// <summary>
        /// Общий счетчик созданных экземпляров.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Высота прямоугальника.
        /// </summary>
        private int _height;

        /// <summary>
        /// Возвращает или задает цвета.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Возвращает или задает значение центра прмоугольника <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает значение идентификатора.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            Id = _allRectanglesCount++;
            Color = DefaultRectangleColor;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="width">Длина.</param>
        /// <param name="height">Высота.</param>
        /// <param name="center"><see cref="Point2D"/> центр.</param>
        public Rectangle(int width, int height, Point2D center)
        {
            Width = width;
            Height = height;
            Color = DefaultRectangleColor;
            Center = center;
            Id = _allRectanglesCount++;
        }

        /// <summary>
        /// Создает копию экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle">Исходный <see cref="Rectangle"/>.</param>
        public Rectangle(Rectangle rectangle)
        {
            Width = rectangle.Width;                 
            Height = rectangle.Height;                  
            Color = rectangle.Color;                 
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);                  
            Id = rectangle.Id;              
        }

        /// <summary>
        /// Возвращает или задает значение длины. Должно быть положительным.
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение высоты. Должно быть положительным.
        /// </summary>
        public int Height
        {
            get => _height;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает кол-во созданных экземпляров <see cref="Rectangle"/>.
        /// </summary>
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