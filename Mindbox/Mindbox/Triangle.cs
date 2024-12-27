using System;

namespace Mindbox
{
    public class Triangle : Shape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Все стороны должны быть положительными числами.");

            if (!IsValidTriangle(firstSide, secondSide, thirdSide))
                throw new ArgumentException("Треугольник с такими сторонами не существует.");

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) * (semiPerimeter - _thirdSide));
        }

        public bool IsRightAngled()
        {
            double[] sides = new[] { _firstSide, _secondSide, _thirdSide };
            Array.Sort(sides);

            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.0001;
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
