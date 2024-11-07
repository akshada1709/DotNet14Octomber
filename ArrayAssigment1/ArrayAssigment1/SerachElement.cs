using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssigment1
{
    public class SearchElement
    {
        public static void SearchEle(int[] a, int ele)
        {
            bool isFound = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ele)
                {
                    Console.WriteLine($"{ele} is found at index {i}");
                    isFound = true;
                    break; 
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{ele} is not found in the array.");
            }
        }

        //static void Main(string[] args)
        //{
        //    //3. Search the element in an array
        //    int[] arr = { 12, 45, 66, 33, 90, 76 };
        //    Console.WriteLine("Enter search element:");
        //    int ele = Convert.ToInt32(Console.ReadLine());
        //
        //    SearchElement.SearchEle(arr, ele);
        //}
    }
}

