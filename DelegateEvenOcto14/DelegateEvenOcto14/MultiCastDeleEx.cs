using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvenOcto14
{
    public delegate int MyDelegate2(int x,int y);//method syntax same we use one delegates
    public delegate string Mydelegate3(string name);//if method syntax is diff then we want another delegates 

    public class MultiCastDeleEx
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public class User
        {
            public string AcceptName(string name)
            {
                return name.ToUpper();
            }
        }
    }

}

