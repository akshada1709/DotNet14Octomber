using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Check if a number is even or odd
            Console.WriteLine("Enter a number to check if it is even or odd:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }

            // 2. Check if number is positive, negative, or zero
            Console.WriteLine("Enter another number to check if it is positive, negative, or zero:");
            int anotherNumber = int.Parse(Console.ReadLine());
            if (anotherNumber > 0)
            {
                Console.WriteLine($"{anotherNumber} is positive.");
            }
            else if (anotherNumber < 0)
            {
                Console.WriteLine($"{anotherNumber} is negative.");
            }
            else
            {
                Console.WriteLine($"{anotherNumber} is zero.");
            }

            // 3. Check if a year is a leap year
            Console.WriteLine("Enter a year to check if it is a leap year:");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
