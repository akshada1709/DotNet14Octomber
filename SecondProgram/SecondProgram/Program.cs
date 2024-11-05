using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";

            // 1. Concatenation using +
            string concatenated = word1 + " " + word2;
            Console.WriteLine("Concatenation using +: " + concatenated);

            // 2. Using placeholders {}
            string formatted = string.Format("{0} {1}", word1, word2);
            Console.WriteLine("Using placeholders: " + formatted);

            // 3. Using string interpolation
            string interpolated = $"{word1} {word2}";
            Console.WriteLine("Using string interpolation: " + interpolated);
        }
    }
}
