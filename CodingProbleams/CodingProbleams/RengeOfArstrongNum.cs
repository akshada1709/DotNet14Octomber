using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingProbleams
{
    public class RengeOfArstrongNum
    {
        public static bool IsArmstrong(int num)
        {
            int originalNumber = num;
            int sum = 0;


            while (num > 0)
            {
                int digit = num % 10;  // Extract last digit
                sum += digit * digit * digit;   // Add digit^numberOfDigits to sum
                num /= 10;  // Remove last digit
            }

            return sum == originalNumber;  // Check if the sum is equal to the original number
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Armstrong numbers between 1 and 1000 are:");

        //    for (int i = 1; i <= 450; i++)
        //    {
        //        if (IsArmstrong(i))
        //        {
        //            Console.Write(i + " ");
        //        }
        //    }
        //}

        // Method to check if a number is an Armstrong number

    }
}
