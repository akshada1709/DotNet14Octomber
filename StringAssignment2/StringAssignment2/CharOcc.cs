using System;

namespace StringAssignment2
{
    public class CharOcc
    {
        static void Main(string[] args)
        {
            string str = "programming";
            char targetChar = 'g';  // Character to search for

            int count = 0;
            // Iterate through the string
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == targetChar)
                {
                    count++;  // Increment count if character matches
                    Console.WriteLine($"{targetChar} found at position {i}"); // Print the position of the character
                }
            }

            // Output the count with a descriptive message
            Console.WriteLine($"Total occurrences of '{targetChar}': {count}");
        }
    }
}
