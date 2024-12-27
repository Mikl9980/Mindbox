using System;

namespace Mindbox
{
    public class Circle : Shape
    {
        private double _radiusValue;

        public Circle(double radiusValue)
        {
            if (radiusValue <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            _radiusValue = radiusValue;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radiusValue, 2);
        }
    }
}
