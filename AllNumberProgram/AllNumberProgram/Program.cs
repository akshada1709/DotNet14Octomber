using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllNumberProgram
{
  public class Program
    {
        static void Main(string[] args)
        {
            //a) Generate the Fibonacci sequence up to n terms
            //1,1,2,3,5,8,13,21..... n;
            Console.WriteLine("Enter the number of terms :");
            int term=Convert.ToInt32(Console.ReadLine());
            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci sequence:");
            for (int i = 1; i <= term; i++)
            {
                Console.WriteLine(first); // Print the current term
                next = first + second;    // Calculate the next term
                first = second;           // Update first and second for the next iteration
                second = next;
            }
        }
    }
}
