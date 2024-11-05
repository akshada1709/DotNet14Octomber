using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check number is palindrome or not
            Console.WriteLine("Enter your number :");
            int num=Convert.ToInt32(Console.ReadLine());
            //int num = 121;
            int temp = num;
            int rev = 0;

            while (num > 0) {
                int digit = num % 10;
                rev=rev * 10+ digit;
                num = num / 10;

            }
            if (rev == temp)
            {

                Console.WriteLine("Number is palindrome");
            }
            else {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}

/* 
  temp, num=121
    num>0      rem=num%10      rev= rev*10+digit     num=num/10
   121>0=T     1=121%10       rev=(0*10+1)=>1           121/10=>12
   12>0=T      2=12%10        rev=(1*10+2 )=>12          12/10=>2
   1>0=T       0(0.1)=1%10         rev=(0*10+1)=> 1            1/10=>1
      
 */



