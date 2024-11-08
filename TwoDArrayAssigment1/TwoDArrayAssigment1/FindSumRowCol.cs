using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDArrayAssigment1
{
    public class FindSumRowCol
    {
        static void Main(string[] args)
        {
            //6.WAP to find sum of each row and column of a matrix.
            int[,] m2 = { { 3, 5, 7 }, { 1, 2, 3 }, { 0, 1, 2 } };
            int row=m2.GetLength(0);
            int col=m2.GetLength(1);

            for (int i = 0; i < row; i++) 
            {
                int rowsum = 0;
              for (int j = 0; j < col; j++) 
                {
                    rowsum= rowsum+ m2[i,j];
                
                }
                Console.WriteLine($"sum of each row = {rowsum}");
            }

            //col sum
            for(int j=0; j < col; j++) 
            {
               int colsum=0;
                for(int i = 0; i <row; i++) 
                {
                   colsum= colsum+ m2[i,j];
                }
                Console.WriteLine($"sum of each col = {colsum}");
            }

        }
    }
}
