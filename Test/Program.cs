using ShapeCalculator.Shapes;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triangle tr = new Triangle(10, 10, 6);
            Console.WriteLine(tr.IsRight());
        }
    }
}
