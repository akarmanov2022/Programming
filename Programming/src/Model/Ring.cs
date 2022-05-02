using System;
using static Programming.Service.Validator;

namespace Programming.Model
{
    public class Ring
    {
        private double _outerRadius;

        private double _innerRadius;

        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }

        public double OuterRadius
        {
            get => _outerRadius;
            private set
            {
                AssertOnPositiveValue(value, _innerRadius, double.MaxValue, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get => _innerRadius;
            private set
            {
                AssertOnPositiveValue(value, 0, _outerRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        public Point2D Center { set; get; }

        public double Area =>
            Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
    }
}