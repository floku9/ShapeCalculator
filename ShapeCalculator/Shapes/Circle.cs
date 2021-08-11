using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculator.Shapes
{
    public class Circle :  IShape
    {
        public double Radius { get; private set; }
        
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше нуля");
            Radius = radius;
        }

        /// <summary>,
        /// Вычислить площадь круга
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
