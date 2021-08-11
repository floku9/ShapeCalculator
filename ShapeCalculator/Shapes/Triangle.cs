using System;
using System.Collections.Generic;

namespace ShapeCalculator.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        private double MaxSide { get; set; }
        public double Perimeter { get; private set; }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0 )
                throw new ArgumentOutOfRangeException("Сторона треугольника не может быть отрицательной");

            SideA = a;
            SideB = b;
            SideC = c;

            MaxSide = Math.Max(a, Math.Max(b, c));
            Perimeter = a + b + c;
            if (MaxSide > Perimeter - MaxSide)
                throw new ArgumentException("Набиольшая сторона треугольника не может быть больше суммы двух других сторон");
        }
        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            List<double> Sides = new List<double> { SideA, SideB, SideC };
            Sides.Remove(MaxSide);
            return Math.Pow(MaxSide, 2) == Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2);
        }
        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            var HalfP = Perimeter / 2;
            return Math.Sqrt(HalfP * (HalfP - SideA) * (HalfP - SideB) * (HalfP - SideC));
        }
    }
}
