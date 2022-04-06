namespace Programming.Model
{
    public class Point2D
    {
        private int _x;
        private int _y;

        public Point2D(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        private void SetY(int y) => _y = y;

        private void SetX(int x) => _x = x;

        public override string ToString()
        {
            return $"({_x}:{_y})";
        }
    }
}