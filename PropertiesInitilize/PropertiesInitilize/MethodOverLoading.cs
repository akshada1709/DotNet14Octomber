using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInitilize
{
    public class MethodOverLoading
    {
        //Addition
        public int Addition(int a,int b) {

            return a + b;
        }

        public int Addition(int a,int b,int c) { return a + b + c; }
        public float Addition(int a, float b, int c) { return (a + b + c); }

        //Substraction
        public int Substraction(int a, int b, int c) { return a - b - c; }
        public float Substraction(float a, int b, int c) {return a - b - c; }

        //Multiplication
        public int Multiplication(int a, int b, int c) { return a * b * c; }
        public float Multiplication(float a, float b, int c) {return (a * b + c); }
    }
}
