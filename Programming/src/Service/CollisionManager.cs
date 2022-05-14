using System;
using Programming.Model;

namespace Programming.Service
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width
                   && rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X
                   && rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height
                   && rectangle1.Center.Y + rectangle1.Height > rectangle2.Center.Y;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            var dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            var c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return c < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}