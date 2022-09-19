using System;
using System.Collections.Generic;
using Programming.Model;

namespace Programming.Service
{
    /// <summary>
    /// Статический класс - фабрика объектов типа <see cref="Rectangle"/>.
    /// </summary>
    public class RectangleFactory
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// Создает список экземпляров класса <see cref="Rectangle"/> в обределенном кол-ве со случайными значениями полей.
        /// </summary>
        /// <param name="count">Кол-во эелементов списка.</param>
        /// <returns>Список объектов <see cref="Rectangle"/>.</returns>
        public static List<Rectangle> GenerateRandomRectangles(int count)
        {
            var rectangles = new List<Rectangle>();

            for (var i = 0; i < count; i++)
            {
                rectangles.Add(new Rectangle
                {
                    Height = (int) Math.Round(Random.NextDouble() * 1000, 2),
                    Width = (int) Math.Round(Random.NextDouble() * 1000, 2),
                    Center = new Point2D(Random.Next(1000), Random.Next(1000))
                });
            }

            return rectangles;
        }

        /// <summary>
        /// Найдет идентификатор объекта типа <see cref="Rectangle"/>
        /// с минимальным значением рейтинга из входного списка объектов типа <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangles">Входной список объектов типа <see cref="Rectangle"/>.</param>
        /// <returns>Идентификатор объекта типа <see cref="Rectangle"/>.</returns>
        public static int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            var maxWidth = 0d;
            var rectangleId = 0;

            if (rectangles != null)
            {
                foreach (var rectangle in rectangles)
                {
                    if (!(maxWidth < rectangle.Width)) continue;

                    maxWidth = rectangle.Width;
                    rectangleId = rectangle.Id;
                }
            }

            return rectangleId;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/> со случайными значениями полей.
        /// </summary>
        /// <param name="maxWidth">Максимальное значение для длины.</param>
        /// <param name="maxHeight">Максимальное значение для высоты.</param>
        /// <returns>Новый объект типа <see cref="Rectangle"/>.</returns>
        public static Rectangle GenerateRandomRectangle(int maxWidth, int maxHeight)
        {
            var height = Random.Next(100, 500);
            var width = Random.Next(100, 500);
            var x = Math.Abs(Random.Next(maxWidth) - width / 2);
            var y = Math.Abs(Random.Next(maxHeight) - height / 2);
            return new Rectangle
            {
                Height = height,
                Width = width,
                Center = new Point2D(x, y)
            };
        }
    }
}