using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample1
{
    class Student2
    {
        public string Name { get; set; }
        public void AttendSession()
        {
            Console.WriteLine($"{Name} is attending a session.");
        }
    }

    class EnggStudent : Student2
    {
        public void DoPractical()
        {
            Console.WriteLine($"{Name} is doing a practical session.");
        }
    }

}
