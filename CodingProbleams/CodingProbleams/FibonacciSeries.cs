using System;

namespace CodingProblems
{
    public class FibonacciSeries
    {
        public static void Fibonac(int terms)
        {
            int first = 0, secterm = 1, thirdterm = 0;

            // Print the first two terms
            Console.WriteLine(first);
            Console.WriteLine(secterm);

            // Calculate and print the rest of the terms
            for (int i = 3; i <= terms; i++)
            {
                thirdterm = first + secterm;
                Console.WriteLine(thirdterm);

                // Update the terms
                first = secterm;
                secterm = thirdterm;
            }
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the number of terms in the Fibonacci series:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    Fibonac(n);
        //}
    }
}
