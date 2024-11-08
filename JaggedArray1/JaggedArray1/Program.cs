using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[4][];

            // assign value for each row
            jarr[0] = new int[4] { 21, 62, 38, 40 }; // 0th row index have 4 cols
            jarr[1] = new int[5] {112,333,90, 22, 44 }; // 1st index row have 2 cols
            jarr[2] = new int[3] { 111, 765, 55 };
            jarr[3] = new int[3] { 6,2,3 };

            //print all the elements
            for (int i = 0; i < jarr.Length; i++)// Length property will represent size of row
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write($"{jarr[i][j]}  ");
                }
                Console.WriteLine();
            }

            // Take user input for jagged array
            Console.WriteLine("Enter the number of rows for your jagged array:");
            int rows = Convert.ToInt32(Console.ReadLine());

            int[][] jarr1 = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the number of elements for row {i + 1}:");
                int cols = Convert.ToInt32(Console.ReadLine());

                jarr1[i] = new int[cols]; // Initialize each row with user-defined size

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    jarr1[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Print user-defined jagged array
            Console.WriteLine("User-defined jagged array elements:");
            for (int i = 0; i < jarr1.Length; i++)
            {
                for (int j = 0; j < jarr1[i].Length; j++)
                {
                    Console.Write($"{jarr1[i][j]}  ");
                }
                Console.WriteLine();
            }

            //for each loop
            foreach(int[] cols in jarr1) 
            {
                foreach (int item in cols)
                {
                    Console.Write($"{item}");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
