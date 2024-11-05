using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment1
{
    public class Triangle:Shape
    {
        private int  l, b,h,area,peri;
        
        public Triangle(int l, int b)
        {
            this.l = l;
            this.b = b;
           
        }

        public override void CalculateArea()
        {
            area = 1/2 * (l * b);
        }

        public override void calculatePerimeter()
        {
            peri = l + b + h;
        }

        public override string ToString()
        {
            return $"Area of triangle is : {area} and Perimeter of triangle is : {peri}";
        }
    }
}
