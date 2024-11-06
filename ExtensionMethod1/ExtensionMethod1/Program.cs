using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if method declare static even extension method need object to call
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Mul(12,3));
            Console.WriteLine(calculation.Add(100,23));
        }
    }
}
