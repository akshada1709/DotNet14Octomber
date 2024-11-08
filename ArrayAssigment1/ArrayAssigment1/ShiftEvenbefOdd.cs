using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssigment1
{
    public class ShiftEvenbefOdd
    {
        //9. Shift even before odd 
       
        public void ShiftEvenBeforeOdd(int[] arr)
        {
            int index = 0;

           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) 
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
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    ShiftEvenbefOdd shiftEvenBeforeOdd = new ShiftEvenbefOdd();

        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    Console.WriteLine("Original Array:");
        //    shiftEvenBeforeOdd.PrintArray(arr);

        //    shiftEvenBeforeOdd.ShiftEvenBeforeOdd(arr);
        //    Console.WriteLine("Array after shifting even numbers before odd numbers:");
        //    shiftEvenBeforeOdd.PrintArray(arr);

        //    Console.ReadLine();
        //}
    }
}