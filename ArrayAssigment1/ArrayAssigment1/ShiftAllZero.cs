using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ArrayAssignment1
{
    public class ShiftAllZero
    {
        // Method to shift all zeros to the beginning of the array
        public static void ShiftZerosToBeginning(int[] arr)
        {
            int n = arr.Length;
            int j = n - 1;  // Index for the end of the array

            // Traverse the array from end to start
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    arr[j] = arr[i];
                    j--;
                }
            }

            // Fill the remaining positions with zeros
            while (j >= 0)
            {
                arr[j] = 0;
                j--;
            }
        }

        // Method to shift all zeros to the end of the array
        public static void ShiftZerosToEnd(int[] arr)
        {
            int n = arr.Length;
            int j = 0;  // Index for the start of the array

            // Traverse the array
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    arr[j] = arr[i];
                    j++;
                }
            }

            // Fill the remaining positions with zeros
            while (j < n)
            {
                arr[j] = 0;
                j++;
            }
        }

        // Method to print the array
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 0, 2, 0, 3, 0, 4, 5 };
            int[] array2 = (int[])array1.Clone();

            Console.WriteLine("Original Array:");
            ShiftAllZero.PrintArray(array1);

            ShiftAllZero.ShiftZerosToBeginning(array1);
            Console.WriteLine("Array after shifting zeros to the beginning:");
            ShiftAllZero.PrintArray(array1);

            ShiftAllZero.ShiftZerosToEnd(array2);
            Console.WriteLine("Array after shifting zeros to the end:");
            ShiftAllZero.PrintArray(array2);
        }
    }
}

