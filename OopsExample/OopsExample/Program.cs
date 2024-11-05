using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExample
{ // Abstract Class - Abstraction
    public abstract class Employee
    {
        // Private fields - Encapsulation
        private int employeeId;
        private string name;
        private double salary;

        // Constructor
        public Employee(int employeeId, string name, double salary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.salary = salary;
        }

        // Public methods - Encapsulation
        public void GetEmployeeDetails()
        {
            Console.WriteLine($"ID: {employeeId}, Name: {name}, Salary: {salary}");
        }

        // Abstract method to be implemented by derived classes - Polymorphism
        public abstract void Work();
    }

    // Derived class - Inheritance
    public class Manager : Employee
    {
        public Manager(int employeeId, string name, double salary)
            : base(employeeId, name, salary)
        {
        }

        // Overriding Work method - Polymorphism
        public override void Work()
        {
            Console.WriteLine("Manager is managing the team.");
        }

        public void ManageTeam()
        {
            Console.WriteLine("Manager is conducting a meeting.");
        }
    }

    // Derived class - Inheritance
    public class Developer : Employee
    {
        public Developer(int employeeId, string name, double salary)
            : base(employeeId, name, salary)
        {
        }

        // Overriding Work method - Polymorphism
        public override void Work()
        {
            Console.WriteLine("Developer is writing code.");
        }

        public void WriteCode()
        {
            Console.WriteLine("Developer is working on the project.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects - Inheritance and Polymorphism in action
            Employee manager = new Manager(1, "John", 85000);
            Employee developer = new Developer(2, "Sarah", 70000);

            // Calling the abstract method - Polymorphism
            manager.Work();
            developer.Work();

            // Encapsulation in action
            manager.GetEmployeeDetails();
            developer.GetEmployeeDetails();

            Console.ReadLine();
        }
    }
}
