using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssigment1
{
    public class SortArray
    {
        static void Main(string[] args)
        {
           
        int[] numbers = { 5, 3, 8, 6, 2, 7, 4, 1 };

        // Display the original array
        Console.WriteLine("Original Array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
    Console.WriteLine();

            // Sort the array in ascending order using Bubble Sort
            for (int i = 0; i<numbers.Length - 1; i++)
            {
                for (int j = 0; j<numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Swap the elements
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            // Display the sorted array
            Console.WriteLine("Sorted Array in Ascending Order:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}
Console.WriteLine();
        }
    }
}