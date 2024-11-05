using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment1
{
    //2. Write a C# program to create an abstract class Shape with abstract methods calculateArea()
    //and calculatePerimeter(). 
    //Create subclasses Circle and Triangle that inherit the Shape class and implement the respective methods
    //to calculate the area and perimeter of each shape.

    abstract public class Shape
    {
        public abstract void CalculateArea();
        public abstract void calculatePerimeter(); 
    }
}
