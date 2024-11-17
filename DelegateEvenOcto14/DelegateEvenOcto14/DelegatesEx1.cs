using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvenOcto14
{
    // we will declare delegate in the namespace
    public delegate int MyDelegate(int x, int y);// variable name can be 

    public class DelegatesEx1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

    }
}
