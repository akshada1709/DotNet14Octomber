using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment1
{
    public class ReverseWord
    {
        static void Main(string[] args)
        {
            //1. Reverse the string word by word
            string str = "akshada gaikwad";
            string[] arr = str.Split(' ');

            string word = "";
            for (int i = arr.Length-1; i >=0; i--) 
            {
                word=word+arr[i]+" ";
              
            }
            Console.WriteLine(word);

        }



    }
}
