using System;

namespace StringAssignment2
{
    public class CheckAnagram
    {
        static void Main(string[] args)
        {
            // Input strings
            string str1 = "listen";
            string str2 = "silent";

            // Check if lengths are different
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("The strings are not anagrams.");
                return;  // No need to check further if lengths are different
            }

            // Convert both strings to character arrays
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            // Sort the character arrays
            Array.Sort(arr1);
            Array.Sort(arr2);

            // Convert the character arrays back to strings and compare
            string sortedStr1 = new string(arr1);
            string sortedStr2 = new string(arr2);

            // Check if the sorted strings are equal
            if (sortedStr1 == sortedStr2)
            {
                Console.WriteLine("The strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
        }
    }
}
