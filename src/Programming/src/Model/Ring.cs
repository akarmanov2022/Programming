using System;
using Programming.Service;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о геометрической фигуре - кольцо.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внитренний радиус.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="innerRadius">Внитренний радиус.</param>
        /// <param name="center">Точка - центр кольца <see cref="Point2D"/>.</param>
        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }

        /// <summary>
        /// Возвращает или задает значение внешнего радиуса. Должно быть больше значения внутреннего кольца.
        /// </summary>
        public double OuterRadius
        {
            get => _outerRadius;
            private set
            {
                Validator.AssertOnPositiveValue(value, _innerRadius, double.MaxValue, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение внешнего радиуса. Должно быть положительным и не больше значения внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get => _innerRadius;
            private set
            {
                Validator.AssertOnPositiveValue(value, 0, _outerRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение центра <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { set; get; }

        /// <summary>
        /// Возвращает площадь фигуры.
        /// </summary>
        public double Area =>
            Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
    }
}