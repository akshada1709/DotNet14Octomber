using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPS4Pillars1
{
    class Student2
    {
        public string Name { get; set; }

        // Constructor to initialize student's name
        public Student2(string name)
        {
            Name = name;
        }

        // Method to calculate result for a student (only theory exam)
        public virtual void GetResult()
        {
            Console.WriteLine($"{Name} has passed the theory exam.");
        }
    }

    // Derived class EnggStudent inheriting from Student
    class EnggStudent2 : Student2
    {
        // Constructor to initialize EnggStudent's name using base class constructor
        public EnggStudent2(string name) : base(name)
        {
        }

        // Overriding GetResult method for EnggStudent (Theory, Practical, and Viva)
        public override void GetResult()
        {
            Console.WriteLine($"{Name} has passed the theory exam, practical, and viva.");
        }
    }
    public class Polymorphism
    {
        // Create a Student object
        Student2 student = new Student2("Akshad");
        //student.GetResult();  // Output: Akshad has passed the theory exam.

            // Create an EnggStudent object (derived class)
            EnggStudent2 enggStudent = new EnggStudent2("Shivani");
        //enggStudent.GetResult();  // Output: Shivani has passed the theory exam, practical, and viva.
    }
}
