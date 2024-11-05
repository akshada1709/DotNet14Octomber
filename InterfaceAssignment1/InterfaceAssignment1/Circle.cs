using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment1
{
    public class Circle:Shape
    {
        private float pi,area,peri;
        private int r;

        public Circle(float pi, int r)
        {
            this.pi = pi;
            this.r = r;
            
        }

        public override void CalculateArea()
        {
            area = pi * r * r;

        }

        public override void calculatePerimeter()
        {
            peri = 2*pi * r;
        }

        public override string ToString()
        {
            return $"Area of circle is : {area} / Perimeter of circle is : {peri}";
        }
    }
}
