using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArrayEx1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //two d array declaration
            int[,] arr = new int[4, 3] {

                      { 10,20,30},
                      { 40,50,60},
                      { 22,44,66},
                      { 23,53,83}
            };

            Console.WriteLine(arr[0,1]);
            //print all elemets of an array

            for (int row = 0; row < 4; row++) //row
            {
               for(int col= 0;col<3; col++) //col
                {
                    Console.Write($" arr[ {row},{col}] = {arr[row,col]}");
                }
                Console.WriteLine();
            }

            //form user input
            Console.WriteLine("Enter the number of rows for your array:");
            int userRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns for your array:");
            int userCols = Convert.ToInt32(Console.ReadLine());

            int[,] userArray = new int[userRows, userCols];

            // Input array elements from user
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userCols; j++)
                {
                    Console.Write($"Enter element at position [{i},{j}]: ");
                    userArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Print the user-defined array
            Console.WriteLine("Your array elements:");
            for (int i = 0; i < userRows; i++)
            {
                for (int j = 0; j < userCols; j++)
                {
                    Console.Write($" userArray[{i},{j}] = {userArray[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
