using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample1
{
    class Student
    {
        public virtual void GetResult()
        {
            Console.WriteLine("Student result based on general exams.");
        }
    }

    class EnggStudent : Student
    {
        public override void GetResult()
        {
            Console.WriteLine("EnggStudent result based on theory, practical, and viva.");
        }
    }

}
