namespace Programming.Model
{
    public class Point2D
    {
        public Point2D(int x, int y)
        {
            Y = y;
            X = x;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X}:{Y})";
        }
    }
}