using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssigment1
{
    public class SumEquivalent
    {
        public static void SumEquiNum(int[]a,int num) 
        {
            bool isfound=false;
            for (int i = 0; i < a.Length; i++) 
            {
                for (int j = i+1; j < a.Length; j++) 
                {
                    if (a[i] + a[j] == num) 
                    {
                        Console.WriteLine($" Pair of elements is found = {a[i]} ,{a[j]}");
                        isfound = true;
                    }
                   
                }

            }

            if (!isfound)
            {
                Console.WriteLine("No pairs found ");
            }
        }

        //static void Main(string[] args)
        //{
        //    //2. Pair of elements in arrays whose sum is equivalent to given number
        //    int[] arr9 = { 912, 45, 663, 33, 90, 76 };
        //    int givenNum = 135;

        //    SumEquivalent.SumEquiNum(arr9, givenNum);
        //}
       
        
    }
}
