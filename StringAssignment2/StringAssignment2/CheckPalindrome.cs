using System;

namespace StringAssignment2
{
    public class CheckPalindrome
    {
        static void Main(string[] args)
        {
            // Input string
            string str = "madam";

            // Step 1: Store the original string in a temporary variable
            string temp = str;

            // Step 2: Reverse the string
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];  // Concatenate characters in reverse order
            }

            // Step 3: Compare the reversed string with the original string
            if (rev == temp)
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }
    }
}
