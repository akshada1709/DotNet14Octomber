using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment1
{
   public class CheckOcc
    {
        int count = 0;
        public void OccuChar(string s, char c) 
        {
            for (int i = 0; i < s.Length; i++) 
            {
            
              if(s[i] == c) 
                {
                 count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"{c} occured {count} times in a string");

        }
        //static void Main(string[] args)
        //{
        //    //Check occurrences of particular  characters, how many times it’s there
        //    //and which diff positions.

        //    string str = "akshada gaikwad";
        //    char ch = 'a';
        //    CheckOcc oc=new CheckOcc();
        //    oc.OccuChar(str, ch);


        //}
    }
}
