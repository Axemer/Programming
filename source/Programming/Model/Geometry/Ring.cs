using System;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные кольца и создаёт его экземпляр.
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создаёт кольцо.
        /// </summary>
        /// <param name="center">Центр прямоугольника состоящий из координат x и y.</param>
        /// <param name="internalRadius">Внутренний радиус. Всегда положительный и меньше внешнего.</param>
        /// <param name="externalRadius">Внешний радиус. Всегда положительный и больше внутреннего.</param>
        public Ring(Point2D center,
            double outerRadius,
            double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        /// <summary>
        /// Точка на координатной сетке.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт внешний радиус. Всегда положительный и больше внутреннего.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius), value);
                Validator.AssertValueInRange(nameof(OuterRadius), value, _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт внутрений радиус. Всегда положительный и больше внутреннего.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius), value);
                Validator.AssertValueInRange(nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь, равную S = Pi * R^2.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}
