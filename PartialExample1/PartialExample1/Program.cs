using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc c1 = new Calc();
            Console.WriteLine(c1.Add(20, 40));
            Console.WriteLine(c1.Multiply(5, 8));
            Console.WriteLine(c1.Sub(56, 33));

        }
    }
}
