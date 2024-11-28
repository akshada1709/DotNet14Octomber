using System;

namespace StringAssignment2
{
    public class OccEachChar
    {
        static void Main(string[] args)
        {
            string str = "programming";  // Input string

            // Loop through each character in the string
            for (int i = 0; i < str.Length; i++)
            {
                // Check if the character has already been processed
                if (str[i] != '0') // Skip if it's marked as processed
                {
                    char currentChar = str[i];
                    int count = 1;  // Start counting occurrences of currentChar

                    // Loop through the rest of the string to count occurrences
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[j] == currentChar)
                        {
                            count++;  // Increment count if the character matches
                            str = str.Substring(0, j) + '0' + str.Substring(j + 1); // Mark character as processed
                        }
                    }

                    // Print the character and its count
                    Console.WriteLine($"Character '{currentChar}' occurs {count} time(s).");
                }
            }
        }
    }
}
