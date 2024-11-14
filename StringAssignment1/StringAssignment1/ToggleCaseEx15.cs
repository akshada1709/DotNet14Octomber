using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StringAssignment1
{
    public class ToggleCaseEx15
    {
        public static void Main(string[] args)
        {
            // Input string
            string input = "hello world this is a test";
            string result = ToggleFirstCharCase(input);
            Console.WriteLine("Result: " + result);
        }

        public static string ToggleFirstCharCase(string str)
        {
            char[] charArray = str.ToCharArray(); // Convert the string to a char array to manipulate each character

            bool newWord = true; // Tracks if the current character is the start of a new word

            for (int i = 0; i < charArray.Length; i++)
            {
                // Check for spaces and set newWord to true for the next character after a space
                if (charArray[i] == ' ')
                {
                    newWord = true;
                }
                else if (newWord)
                {
                    // Toggle case if it’s the start of a new word
                    if (charArray[i] >= 'a' && charArray[i] <= 'z')
                    {
                        // Convert lowercase to uppercase
                        charArray[i] = (char)(charArray[i] - 'a' + 'A');
                    }
                    else if (charArray[i] >= 'A' && charArray[i] <= 'Z')
                    {
                        // Convert uppercase to lowercase
                        charArray[i] = (char)(charArray[i] - 'A' + 'a');
                    }

                    newWord = false; // Set to false until next space
                }
            }

            return new string(charArray); // Convert the char array back to a string
        }
    }
}

