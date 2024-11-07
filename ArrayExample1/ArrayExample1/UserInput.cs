using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample1
{
    public class UserInput
    {
        static void Main(string[] args)
        {
            //Accept the 5 elements from user & display

            int[] arr1 = new int[5];
            Console.WriteLine("Enter 5 elements");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Print the elements in for each loop");
            foreach (int a1 in arr1)
            {
                Console.WriteLine(a1);
            }

            //Declare an array of size 10, use Sort(), Reverse(), Copy(), Clear()
            int[] arr2 = new int[10] { 23, 11, 56, 32, 78, 90, 0, 93, 1, 88 };
            int[] arr3 = new int[4];

            Console.WriteLine("Original array ");
            foreach(int aa in arr2) 
            {
                Console.WriteLine(aa);
            }

            //sort array
            Console.WriteLine($"Sort array is");
            Array.Sort(arr2);
            foreach (int a2 in arr2)
            {

                Console.WriteLine(a2);
            }
            //Reverse array
            Console.WriteLine($"Reverse array is");
            Array.Reverse(arr2);
            foreach (int a2 in arr2)
            {

                Console.WriteLine(a2);
            }
            //copy array
            Console.WriteLine($"copy array is");
            Array.Copy(arr2, arr3, 3);
            foreach (int a3 in arr3)
            {

                Console.WriteLine(a3);
            }

            //clear array
            Console.WriteLine($"clear array is ");
            Array.Clear(arr1, 1, 3);
            foreach (int a1 in arr1)
            {

                Console.WriteLine(a1);
            }

        }
    }
}
