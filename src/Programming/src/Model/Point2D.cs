namespace Programming.Model
{
    /// <summary>
    /// Определяет точу в двумерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Значение координаты по X.</param>
        /// <param name="y">Значение координаты по Y.</param>
        public Point2D(int x, int y)
        {
            Y = y;
            X = x;
        }

        public Point2D()
        {
        }

        /// <summary>
        /// Возвращает или задает значение координаты X.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Возвращает или задает значение координаты Y.
        /// </summary>
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}:{Y})";
        }
        
        protected bool Equals(Point2D other)
        {
            return X == other.X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Point2D) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}