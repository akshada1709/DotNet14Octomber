using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod1
{
    public static class Calc
    {
        // extension method syntax
        // first parameter should be the name of class, for which we want to add method

        public static int Mul(this Calculation c1,int a,int b) 
        {
           return a* b; 
        }
    }
}
