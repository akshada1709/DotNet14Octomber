using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvenOcto14
{
    public class Student
    {
        // event
        public event DisplayMessage Pass;
        public event DisplayMessage Fail;

        public void AcceptMarks(int marks)
        {
            if (marks >= 40)
            {
                Pass();  
            }
            else
            {
                Fail();
            }
        }

    }
}
