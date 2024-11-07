using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Abstraction
            Student student = new HighSchoolStudent();
            student.GiveExam();
            student.GetResult();

            //Encapsulation
            Student1 student1 = new Student1();
            student1.RollNo = 101;
            student1.Name = "John Doe";
            student1.DisplayStudentInfo();

            //Inheritance
            EnggStudent enggStudent = new EnggStudent();
            enggStudent.Name = "John Doe";
            enggStudent.AttendSession();
            enggStudent.DoPractical();

            //Polymorphism
        }
    }
}
