using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefkeyWordExample1
{
    public class Program
    {
        // interchange the values using ref type
        static void SwapValue(ref int a, ref int b)  // input -> a=10,b=20   output--> a=20, b=10
        {
            int temp;
            temp = a; // temp=10
            a = b; // a=20
            b = temp;// b=10
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before swap a={a} , b={b}");
            SwapValue(ref a, ref b);
            Console.WriteLine($"After swap a={a} , b={b}");

        }
    }
}
