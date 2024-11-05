using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assingment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# program to check whether a year is leap year or not
            //int year = 2024;
            Console.WriteLine("Enter your year");
            int year=Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {

                Console.WriteLine($"{year} is a leap year");
            }
            else {
                Console.WriteLine($"{year} is not a leap year");
            }

            //2.Write a C# program to check whether a number is divisible by 5 and 11 or not  
            int num2 = 110;
            if (num2 % 5 == 0 && num2 % 11 == 0)
            {

                Console.WriteLine($"{num2} is divisible by 5 and 11");
            }
            else {

                Console.WriteLine($"{num2} is not divisible by 5 and 11");
            }



            //3.Write a C# program to find maximum between three numbers

            int a = 12, b = 34, c = 23;
           
            if (a > b)
            {
              
                Console.WriteLine($"{a} is maximum");
            }
            else if (b > c)
            {
               

                Console.WriteLine($"{b} is maximum");
            }
            else if (c >a)
            {
               
                Console.WriteLine($"{c} is maximum");
            }




            //4.Write a C# program to input any alphabet and check whether it is vowel or consonant  
            Console.WriteLine("Enter any alphabet");
            char alpha=Convert.ToChar(Console.ReadLine());

            
            if ((alpha == 'a' || alpha == 'e' || alpha == 'i' || alpha == 'o' || alpha == 'u' ) || (alpha=='A' || alpha=='E' || alpha=='I' || alpha=='O' || alpha=='U'))
            {
                Console.WriteLine($"{alpha}  is vowels");

            }
            else {
                Console.WriteLine($"{alpha}  is consonat");
            }

            //5.Write a C# program to create Simple Calculator
            int result = 0;
            Console.WriteLine("Enter Number 1 :");
            int num5=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 :");
            int num6= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice");
            String choice=Convert.ToString(Console.ReadLine());

            switch (choice) {
                case "Add":
                    result = num5 + num6;
                    break;

                case "Sub":
                    result = num5 - num6;
                    break;
                case "Div":
                    result = num5 / num6;
                    break;
                case "Module":
                    result = num5 % num6;
                    break;
                case "Multipl":
                    result = num5 * num6;
                    break;

                default:
                    Console.WriteLine("Incorrect choice ");
                    break;                    

            }


            //6.Write a C# program to check whether a number is negative, positive or zero  
            Console.WriteLine("Enter your number");
            int num8 =Convert.ToInt32(Console.ReadLine());
            if (num8 > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (num8 < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else {
                Console.WriteLine("Number is zero");
            }

            //7.Write a C# program to input any character and check whether it is alphabet, digit or special character  
            Console.WriteLine("Enter you character");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine($"{ch}  is  alphabet");
            }
            else if (ch >= 0 && ch <= 9)
            {
                Console.WriteLine($"{ch} is digit");
            }
            else {
                Console.WriteLine($"{ch} is special character ");
            }

            //8.Write a C# program to check whether a number is even or odd
            int num = 12;
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is positive");
            }
            else {
                Console.WriteLine("Number is negative");
            }

            //9.Write a C# program print total number of days in a month  

            Console.WriteLine("Enter  month");
            String month=Convert.ToString(Console.ReadLine());

            if (month == "jan" || month == "march" || month == "may" || month == "july" || month == "august" || month == "octomber" || month == "december")
            {

                Console.WriteLine("Days in a month is 31");
            }
            else if (month == "april" || month == "jun" || month == "saptember" || month == "november")
            {

                Console.WriteLine("Days in a month is 30");
            }
            else {
                Console.WriteLine("Days in a month is 28 or 29 ");
            }
            //10.Write a C# program to input basic salary of an employee and calculate its  
            //Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, 
            //DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %

            Console.WriteLine("Enter your salary");
            double basicsal = Convert.ToDouble(Console.ReadLine());
            double hra = 0,da=0;
            if (basicsal <= 10000)
            {
                hra = basicsal * 0.20;
                da = basicsal * 0.80;

            }
            else if (basicsal <= 20000)
            {
                hra = basicsal * 0.25;
                da = basicsal * 0.90;

            }
            else if (basicsal > 20000) {
                hra = basicsal * 0.30;
                da = basicsal * 0.95;
            }
            double grossSal = basicsal + hra + da;
            Console.WriteLine($"Gross salary is : {grossSal}");
        }
    }
}
