using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment2
{
    public class HighFreqChar
    {
        static void Main(string[] args)
        {
            //8.Write a C# program to find the highest frequency character in a string.
            // Input string
            string str = "programming";

            // Step 1: Initialize an array to store the frequency of characters (assuming ASCII characters)
            int[] freqArray = new int[256];  // There are 256 ASCII characters

            // Step 2: Iterate through the string and update the frequency of each character
            foreach (char ch in str)
            {
                freqArray[ch]++;  // Increment the count at the index corresponding to the character
            }

            // Step 3: Find the character with the highest frequency
            char maxChar = ' ';
            int maxFreq = 0;

            for (int i = 0; i < 256; i++)
            {
                if (freqArray[i] > maxFreq)
                {
                    maxFreq = freqArray[i];
                    maxChar = (char)i;  // Convert the index back to the character
                }
            }

            // Step 4: Output the character with the highest frequency
            Console.WriteLine($"The highest frequency character is '{maxChar}' with a frequency of {maxFreq}.");
        }
    }
}