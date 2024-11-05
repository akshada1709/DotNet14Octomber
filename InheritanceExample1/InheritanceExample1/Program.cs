using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample1
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create a Date object
          //    Date joinDate = new Date(23, 10, 2024); // October 23, 2024

            //    // Create a CEO object and calculate salary
            //    Employee emp = new Ceo("Akshada", 25000, joinDate, 1500);
            //    emp.CalculateSalary();

            //    // Display employee (CEO) details
            //    Console.WriteLine(emp);

            Shape shape = new Circle(5);
            shape.CalculateArea();
            Console.WriteLine(shape);

        }
    }
}
