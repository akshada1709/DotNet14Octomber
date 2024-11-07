using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample1
{
    abstract class Student
    {
        // Abstract methods: Only declare tasks, implementation will be provided in subclasses
        public abstract void GiveExam();
        public abstract void GetResult();
    }

    class HighSchoolStudent : Student
    {
        public override void GiveExam()
        {
            Console.WriteLine("HighSchoolStudent is giving a theoretical exam.");
        }

        public override void GetResult()
        {
            Console.WriteLine("HighSchoolStudent result is based on theory exam.");
        }
    }

    
}
