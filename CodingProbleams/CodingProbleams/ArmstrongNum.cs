using System;

namespace ArmstrongNumber
{
    public class Program
    {

        public static bool IsArmstrong(int num)
        {
            int originalNumber = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;  // Get the last digit
                sum += digit * digit * digit;  // Add the cube of the digit to sum
                num /= 10;  // Remove the last digit
            }

            return sum == originalNumber;  // Check if sum equals the original number
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter your number:");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (IsArmstrong(number))
        //    {
        //        Console.WriteLine($"{number} is an Armstrong number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not an Armstrong number.");
        //    }
        //}

        // Method to check if a number is an Armstrong number

    }
}
