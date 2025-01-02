using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS4Pillars1
{
    public class Encapsulation
    {
        class Student
        {
            // Private data members (internal details hidden)
            private string studentName;
            private string prfNumber;
            private string contact;
            private string email;
            private int marks;  // Internal data for marks (hidden from user)
            private string result;  // Encapsulated attribute for the result

            // Constructor
            public Student(string studentName, string prfNumber, string contact, string email, int marks)
            {
                this.studentName = studentName;
                this.prfNumber = prfNumber;
                this.contact = contact;
                this.email = email;
                this.marks = marks;  // Set marks privately
                this.result = "Not Available";  // Initial result is set to "Not Available"
            }

            // Public method to interact with the encapsulated result
            public void GiveExam()
            {
                // Hidden task: Logic for giving the exam (could involve complex operations)
                Console.WriteLine($"{studentName} is taking the exam...");
                // Internal marks are hidden from the user, no direct access.
            }

            // Private method to calculate the result based on marks (hidden logic)
            private void CalculateResult()
            {
                //double percentage = (double)totalMarksObtained / totalMaxMarks * 100;
                // Logic to determine the result based on marks
                if (marks >= 50)
                {
                    result = "Pass";
                }
                else
                {
                    result = "Fail";
                }
            }

            // Public method to get the result (hidden logic, only visible output)
            public string GetResult()
            {
                // Ensure result is calculated first before returning
                CalculateResult();
                return result;
            }

            // Public method to display student details (No direct access to internal data)
            public void DisplayStudentDetails()
            {
                Console.WriteLine($"Student Name: {studentName}");
                Console.WriteLine($"PRF Number: {prfNumber}");
                Console.WriteLine($"Contact: {contact}");
                Console.WriteLine($"Email: {email}");
            }
        }
        static void Main(string[] args)
        {
            // Create an instance of Student with marks
            Student student = new Student("Akshad Gaikwad", "PRF12345", "9876543210", "akshad@example.com", 65);

            // Display student details (without exposing internal state)
            student.DisplayStudentDetails();

            // Student gives the exam (encapsulated logic)
            student.GiveExam();

            // Get the result (hidden calculation logic is invoked internally)
            Console.WriteLine($"Student Result: {student.GetResult()}");

        }
    }
}
