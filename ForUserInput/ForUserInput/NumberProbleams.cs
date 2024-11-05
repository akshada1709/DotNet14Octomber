using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUserInput
{
    internal class NumberProbleams
    {
        static void Main(string[] args)
        {
            //Arithmatic Oprators
            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition of two numbers is: {num1 + num2}");
            Console.WriteLine($"Subtraction of two numbers is: {num1 - num2}");
            Console.WriteLine($"Multiplication of two numbers is: {num1 * num2}");
            Console.WriteLine($"Modulus of two numbers is: {num1 % num2}");

            // division with precision
            double divisionResult = (double)num1 / num2;
            Console.WriteLine($"Division of two numbers is: {divisionResult}");

            //Relational Oprators
            Console.WriteLine("Check numbers is greater than or less than");
                      
            Console.WriteLine($"Check num1 is greater than num2:{num1 > num2}");
            Console.WriteLine($"Check num1 is less than num2:{num1 < num2}");
            Console.WriteLine($"Check num1 is greater than or equal to num2:{num1 >= num2}");
            Console.WriteLine($"Check num1 is less than or equal to num2:{num1 <= num2}");

            Console.WriteLine("Check User is eligible for blood donation ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{weight >= 50} your eligible for blood donation");

            Console.WriteLine($"{weight < 50} your not eligible for blood donation");

            //Logical Operators
            Console.WriteLine("Check User is eligible for interview ");

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your degree:");
            string degree=Convert.ToString(Console.ReadLine());

            Console.WriteLine($"{degree=="BCS" && age==18} your are eligible for interview");
            
        }
    }
}
