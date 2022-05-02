using System;
using System.Collections.Generic;
using System.Drawing;
using Programming.Model;
using Programming.Model.Enum;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.Service
{
    public class RectangleFactory
    {
        private static readonly Random Random = new Random();


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

        public static Rectangle GenerateRandomRectangle(int maxWidth, int maxHeight)
        {
            return new Rectangle
            {
                Height = Random.Next(100, 500),
                Width = Random.Next(100, 500),
                Center = new Point2D(Random.Next(maxWidth), Random.Next(maxHeight))
            };
        }
    }
}