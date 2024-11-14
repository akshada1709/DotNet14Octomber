using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment1
{
    public class StringAnagram
    {
        public void FindAngram(string s1,string s2) 
        {
            //length are not equal
            if (s1.Length != s2.Length) 
            {
                Console.WriteLine("string is not anagram");
                return;
            }

            //sort the string
            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);

            string sorts1 = new string(ch1);
            string sorts2 = new string(ch2);
            if (sorts1 != sorts2)
            {
                Console.WriteLine("Sting is not anagram");
            }
            else 
            {
                Console.WriteLine("Sting is  anagram");
            }
        }

        //static void Main(string[] args)
        //{

        //    string str1 = "silent";
        //    string str2 = "listen";

        //    StringAnagram s = new StringAnagram();
        //    s.FindAngram(str1,str2);
        //}
    }
}
