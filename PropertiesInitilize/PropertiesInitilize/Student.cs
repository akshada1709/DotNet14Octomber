using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInitilize
{
   public class Student
    {
        private int rollNo;
        private string name;
        private int marks;

        public int RollNo
        {
            set { rollNo = value; }
            get { return rollNo; }
        }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Marks
        {
            set {marks = value; }
            get { return marks; }
        }
    }
}
