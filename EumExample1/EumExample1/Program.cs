using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EumExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Suraj", Department.Sales, Roles.Manager);
            Console.WriteLine(e1);

        }
    }
}
