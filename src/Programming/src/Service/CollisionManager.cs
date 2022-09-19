using System;
using Programming.Model;

namespace Programming.Service
{
    /// <summary>
    /// Статический класс для проверки коллизии.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Статический метод. Проверяет наличие коллизии между двумя объектами типа <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle1">Первый объект типа <see cref="Rectangle"/>.</param>
        /// <param name="rectangle2">Второй объект типа <see cref="Rectangle"/>.</param>
        /// <returns>Вернет true, если два объекта типа <see cref="Rectangle"/> имеют коллизию, иначе - false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width
                   && rectangle1.Center.X + rectangle1.Width > rectangle2.Center.X
                   && rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height
                   && rectangle1.Center.Y + rectangle1.Height > rectangle2.Center.Y;
        }

        /// <summary>
        /// Статический метод. Проверяет наличие коллизии между двумя объектами типа <see cref="Ring"/>.
        /// </summary>
        /// <param name="ring1">Первый объект типа <see cref="Ring"/>.</param>
        /// <param name="ring2">Второй объект типа <see cref="Ring"/>.</param>
        /// <returns>Вернет true, если два объекта типа <see cref="Ring"/> имеют коллизию, иначе - false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            var dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            var c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return c < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}