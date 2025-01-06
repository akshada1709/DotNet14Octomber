using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS4Pillars1
{

    abstract class Student
    {
        public string StudentName { get; set; }
        public string PRFNumber { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public Student(string studentName, string pRFNumber, string contact, string email)
        {
            StudentName = studentName;
            PRFNumber = pRFNumber;
            Contact = contact;
            Email = email;
        }

        public abstract void FillExamForm();
        public abstract void GiveTeacherFeedback();

    }

    class CollegeStudent : Student
    {
        public string TeacherName { get; set; }

        public CollegeStudent(string studentName, string prfNumber, string contact, string email, string teacherName)
            : base(studentName, prfNumber, contact, email)
        {
            TeacherName = teacherName;
        }

        // Implementation of abstract methods
        public override void FillExamForm()
        {
            Console.WriteLine("Filling exam form...");
            Console.WriteLine("Details Required:");
            Console.WriteLine($"PRF Number: {PRFNumber}");
            Console.WriteLine($"Name: {StudentName}");
            Console.WriteLine($"Contact: {Contact}");
            Console.WriteLine($"Email: {Email}");
        }

        public override void GiveTeacherFeedback()
        {
            Console.WriteLine("Giving feedback for teacher...");
            Console.WriteLine("Details Required:");
            Console.WriteLine($"Student Name: {StudentName}");
            Console.WriteLine($"Teacher Name: {TeacherName}");
        }
    }


    public class Abstraction
    {
        static void Main(string[] args)
        {
            // Create an instance of CollegeStudent
            CollegeStudent student = new CollegeStudent(
                "Akshad Gaikwad",
                "PRF12345",
                "9876543210",
                "akshad@example.com",
                "Mr. Sharma"
            );



            // Perform operations
            student.FillExamForm();
            Console.WriteLine();
            student.GiveTeacherFeedback();

        }
    }
}
