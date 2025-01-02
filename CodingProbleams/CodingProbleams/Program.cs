using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodingProbleams
{
    public class Program
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }


        //static void Main(string[] args)
        //{
        //    //check single numer is prime or not
        //    Console.WriteLine("Enter your number ");
        //    int number=Convert.ToInt32(Console.ReadLine());

        //    if (IsPrime(number))
        //    {
        //        Console.WriteLine($"{number} is a prime number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not a prime number.");
        //    }
        //}



    }
}
