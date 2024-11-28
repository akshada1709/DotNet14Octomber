using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment1
{
    public class MostRepeatedWord
    {
        static void Main(string[] args)
        {
            //3.WAP to find the most repeated word in a string

            string str = "i love java,java is simple and java is platform independent";

           
            string[] words = str.Split(' ');

            
            int[] wordCount = new int[words.Length];

            
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        wordCount[i]++;
                    }
                }
            }

            
            int maxCount = 0;
            string mostRepeatedWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (wordCount[i] > maxCount)
                {
                    maxCount = wordCount[i];
                    mostRepeatedWord = words[i];
                }
            }

         
            Console.WriteLine($"The most repeated word is '{mostRepeatedWord}' with {maxCount} occurrences.");
        }
    }
}
        
