
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingProbleams
{
    public class Prime100To200
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
        //    //Find all prime numbers between 100 and 200.

        //    Console.WriteLine("Prime numbers between 100 and 200 are:");

        //    for (int i = 101; i <= 200; i=i+2)
        //    {
        //        if (IsPrime(i))
        //        {
        //            Console.Write($" {i} ");
        //        }
        //    }
        //}


    }
}