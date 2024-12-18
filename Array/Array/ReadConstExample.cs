using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Circle
    {
        public const double pi = 3.14;
        public readonly double radius;

        public Circle(double radius) 
        {
            this.radius = radius;
        }

        public double CalculateArea() 
        {
            return pi * radius * radius;
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

        }
    }
}
