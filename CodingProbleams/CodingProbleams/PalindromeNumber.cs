using System;

namespace CodingProblems
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int num)
        {
            int originalNumber = num;
            int reversedNumber = 0;

            // Reverse the number
            while (num > 0)
            {
                int digit = num % 10; // Get the last digit
                reversedNumber = (reversedNumber * 10) + digit; // Build the reversed number
                num /= 10; // Remove the last digit
            }

            // Check if the original number equals the reversed number
            return originalNumber == reversedNumber;
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a number to check if it is a palindrome:");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (IsPalindrome(number))
        //    {
        //        Console.WriteLine($"{number} is a palindrome.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not a palindrome.");
        //    }
        //}
    }
}
