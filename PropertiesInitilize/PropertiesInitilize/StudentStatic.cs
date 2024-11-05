using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInitilize
{
    public class StudentStatic
    {
        private int rollNo;
        private string name;
        private int marks;
        private static int count;

        static StudentStatic()
        {
            count = 0;  // count=102
        }

    }
}
