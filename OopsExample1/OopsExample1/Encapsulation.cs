using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample1
{
    class Student1
    {
        // Private fields: Hidden data of the class
        private int rollNo;
        private string name;

        // Public getter and setter methods
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Roll No: {rollNo}, Name: {name}");
        }
    }
}
