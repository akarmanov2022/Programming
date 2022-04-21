using System;
using System.Collections.Generic;
using System.Drawing;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.Service
{
    public class RectangleService
    {
        public static List<Rectangle> GenerateRandomRectangles(int count)
        {
            var random = new Random();
            var colors = Enum.GetValues(typeof(Color));
            var rectangles = new List<Rectangle>();

            for (var i = 0; i < colors.Length; i++)
            {
                var colorId = random.Next(0, colors.Length);
                rectangles.Add(new Rectangle
                {
                    Length = Math.Round(random.NextDouble() * 100, 2),
                    Width = Math.Round(random.NextDouble() * 100, 2),
                    Color = colors.GetValue(colorId).ToString(),
                    Center = new Point2D(random.Next(100), random.Next(100))
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
    }
}