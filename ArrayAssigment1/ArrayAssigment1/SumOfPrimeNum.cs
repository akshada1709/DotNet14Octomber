using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssigment1
{
   public class SumOfPrimeNum
    {
        public static bool Isprime(int num) 
        {

            if (num <= 1) 
            {
              return false;
            }

            for (int i = 2; i <= num / 2; i++) 
            {
                if (num % i == 0) 
                {
                    return false;
                }
            }
            return true;
        }

        public static int PrimeNumSum(int[] a) 
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) 
            
            {
                if (Isprime(a[i])) 
                {
                   sum=sum+a[i];
                }
            }
            return sum;
        }
        //static void Main(string[] args)
        //{
        //    //9. Sum of prime number in array
        //    int[] arr9 = {1,2,3,4,5 };
         
        //    int result=SumOfPrimeNum.PrimeNumSum(arr9);
        //    Console.WriteLine($"Prime number sum is {result}");
        //}
    }
}
