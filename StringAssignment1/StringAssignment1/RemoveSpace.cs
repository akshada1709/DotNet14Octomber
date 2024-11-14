using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StringAssignment1
{
    public class RemoveSpace
    {
        public static void Main(string[] args)
        {
            // Input string with extra spaces
            string input = "   This   is    a   test   string.  ";
            string result = RemoveExtraSpaces(input);
            Console.WriteLine("Result: '" + result + "'");
        }

        public static string RemoveExtraSpaces(string str)
        {
            char[] charArray = str.ToCharArray();
            StringBuilder result = new StringBuilder();

            bool inWord = false; // Flag to indicate if we are inside a word

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != ' ')
                {
                    // If it's a non-space character, add it to the result and mark that we're inside a word
                    result.Append(charArray[i]);
                    inWord = true;
                }
                else if (inWord)
                {
                    // If it's a space and we're at the end of a word, add a single space to separate words
                    result.Append(' ');
                    inWord = false;
                }
            }

            // Remove trailing space if present
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result.Remove(result.Length - 1, 1);
            }

            return result.ToString();
        }
    }
}
