using System;
using System.Collections.Generic;
using System.Linq;
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
                var rectangle = new Rectangle
                {
                    Width = Random.Next(1, 100),
                    Height = Random.Next(1, 100),
                    Center = new Point2D(x: Random.Next(1, 100), y: Random.Next(1, 100))
                };
                rectangles.Add(rectangle);
            }

            return rectangles;
        }

        /// <summary>
        /// Найдет идентификатор объекта типа <see cref="Rectangle"/>
        /// с минимальным значением рейтинга из входного списка объектов типа <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangles">Входной список объектов типа <see cref="Rectangle"/>.</param>
        /// <returns>Идентификатор объекта типа <see cref="Rectangle"/>.</returns>
        public static int FindRectangleWithMaxWidth(IEnumerable<Rectangle> rectangles)
        {
            var maxWidth = 0;
            var id = 0;
            foreach (var rectangle in rectangles.Where(rectangle => rectangle.Width > maxWidth))
            {
                maxWidth = rectangle.Width;
                id = rectangle.Id;
            }

            return id;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/> со случайными значениями полей.
        /// </summary>
        /// <param name="maxWidth">Максимальное значение для длины.</param>
        /// <param name="maxHeight">Максимальное значение для высоты.</param>
        /// <returns>Новый объект типа <see cref="Rectangle"/>.</returns>
        public static Rectangle GenerateRandomRectangle(int maxWidth, int maxHeight)
        {
            return new Rectangle
            {
                Width = Random.Next(1, maxWidth),
                Height = Random.Next(1, maxHeight),
                Center = new Point2D(x: Random.Next(1, maxWidth), y: Random.Next(1, maxHeight))
            };
        }
    }
}