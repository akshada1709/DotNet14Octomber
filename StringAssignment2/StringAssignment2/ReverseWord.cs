using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment2
{
    public class ReverseWord
    {
        static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');
            string reversedStr = "";

            // Loop through the words in reverse order
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedStr += words[i] + " ";
            }

            // Remove trailing space
            return reversedStr.Trim();
        }
        static void Main(string[] args)
        {
            //1. Reverse the string word by word
          
            string str = "i love programming";
            string reversedStr = ReverseWords(str);
            Console.WriteLine(reversedStr);
        }
    }
}
