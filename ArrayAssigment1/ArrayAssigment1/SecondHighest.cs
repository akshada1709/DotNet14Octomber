using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssigment1
{
    public class SecondHighest
    {
        public static void FindSecondHigh(int [] a) 
        {
            int highest = 0,secondHigh=0;
            for (int i = 0; i < a.Length; i++) 
            {

                if (a[i] > highest) 
                {
                    secondHigh = highest;
                    highest = a[i];

                }
                if (a[i]>secondHigh && a[i] != highest) 
                {
                    secondHigh = a[i];
                }
            }
            
            
        }
        //static void Main(string[] args)
        //{
        //    //4. second highest number w/o sorting
        //    int[] arr4 = { 912, 45, 663, 33, 90, 76 };
        //    SecondHighest.FindSecondHigh(arr4);

        //}
    }
}
