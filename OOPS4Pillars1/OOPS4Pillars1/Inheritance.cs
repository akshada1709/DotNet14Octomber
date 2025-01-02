using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS4Pillars1
{
    // Base class Student
    class Student1
    {
        public string Name { get; set; }

        // Constructor to initialize student's name
        public Student1(string name)
        {
            Name = name;
        }

        // Virtual method to simulate giving an exam, allowing override in derived class
        public virtual void GiveExam()
        {
            Console.WriteLine($"{Name} is giving an exam.");
        }

        // Additional method specific to Student (not overridden)
        public void SubmitAssignment()
        {
            Console.WriteLine($"{Name} is submitting the assignment.");
        }
    }

    // Derived class EnggStudent inheriting from Student
    class EnggStudent : Student1
    {
        // Constructor to initialize EnggStudent's name using base class constructor
        public EnggStudent(string name) : base(name)
        {
        }

        // Override the GiveExam method for EnggStudent (specific implementation)
        public override void GiveExam()
        {
            Console.WriteLine($"{Name} is giving an engineering exam.");
        }

        // Additional method specific to EnggStudent
        public void GivePractical()
        {
            Console.WriteLine($"{Name} is giving practical.");
        }
    }

    public class Inheritance
    {
        static void Main(string[] args)
        {
            // Create a Student object
            Student1 student = new Student1("Akshad");
            student.GiveExam();  // Output: Akshad is giving an exam.
            student.SubmitAssignment();  // Output: Akshad is submitting the assignment.

            // Create an EnggStudent object (derived class)
            EnggStudent enggStudent = new EnggStudent("Shivani");
            enggStudent.GiveExam();  // Output: Shivani is giving an engineering exam.
            enggStudent.GivePractical();  // Output: Shivani is giving practical.
        }
    }
}
