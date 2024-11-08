using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssigment1
{
    public class ShiftNegBefPositive
    {
        //10. Shift negative before positive in array
        public void ShiftNegativeBeforePositive(int[] arr)
        {
            int index = 0;

            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) 
                {
                   
                    int temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                    index++;
                }
            }
        }

        public void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
        //static void Main(string[] args)
        //{
        //    ShiftNegBefPositive shiftNegBefPositive = new ShiftNegBefPositive();

        //    int[] arr = { -1, 2, -3, 4, -5, 6, -7, 8, 9 };
        //    Console.WriteLine("Original Array:");
        //    shiftNegBefPositive.PrintArray(arr);

        //    shiftNegBefPositive.ShiftNegativeBeforePositive(arr);
        //    Console.WriteLine("Array after shifting negative numbers before positive numbers:");
        //    shiftNegBefPositive.PrintArray(arr);

        //    Console.ReadLine();
        //}
    }
}
