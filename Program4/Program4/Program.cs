using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 23;
            string name = "Akshada";
            float percentage = 35.5f;
            decimal salary = 55.6M;
            double value = 44777.8;
            bool admin = true;
            uint age = 23; //only allow positive

            //1 + sign use
            Console.WriteLine("Name is :"+name+" and age is:"+age);

            //2 {} using placeholder
            Console.WriteLine("My name is:{0} and my salary is:{1}",name,salary);

            //2 $ using interpolation
            Console.WriteLine($"My age is {age} and my percenatage is : {percentage}");

        }
    }
}
