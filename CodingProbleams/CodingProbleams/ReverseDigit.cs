using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProbleams
{
    public class ReverseDigit
    {
        static void Main(string[] args)
        {
            int num = 123, rev = 0;

            while (num > 0)
            {


                int digit = num % 10;
                rev = rev*10 + digit;
                num = num / 10;
                
            }
            Console.WriteLine(rev);

        }
    }
    
}
