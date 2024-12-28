using System;

// Abstraction
abstract class Student
{
    public int PRN { get; private set; }
    public string Name { get; private set; }
    public string Gender { get; private set; }
    public int Age { get; private set; }
    public string Branch { get; private set; }
    public string Address { get; private set; }

    // Constructor
    protected Student(int prn, string name, string gender, int age, string branch, string address)
    {
        PRN = prn;
        Name = name;
        Gender = gender;
        Age = age;
        Branch = branch;
        Address = address;
    }

    // Abstract method (must be implemented by derived classes)
    public abstract void AttendSession();

    // Concrete methods
    public void WearIdCard()
    {
        Console.WriteLine($"{Name} is wearing the ID card.");
    }

    public void GiveExam()
    {
        Console.WriteLine($"{Name} is giving the exam.");
    }

    public abstract void GetResult(); // Polymorphism
}

// Encapsulation
class RegularStudent : Student
{
    public RegularStudent(int prn, string name, string gender, int age, string branch, string address)
        : base(prn, name, gender, age, branch, address)
    {
    }

    // Implementation of abstract methods
    public override void AttendSession()
    {
        Console.WriteLine("Attending regular classroom sessions.");
    }

    public override void GetResult()
    {
        Console.WriteLine("Result: Based on theory exams.");
    }
}

// Inheritance
class EnggStudent : Student
{
    public EnggStudent(int prn, string name, string gender, int age, string branch, string address)
        : base(prn, name, gender, age, branch, address)
    {
    }

    // Additional task
    public void GivePractical()
    {
        Console.WriteLine("Giving practical exams.");
    }

    public void AttendIndustryVisit()
    {
        Console.WriteLine("Attending an industry visit.");
    }

    // Override abstract methods
    public override void AttendSession()
    {
        Console.WriteLine("Attending engineering classroom sessions.");
    }

    public override void GetResult()
    {
        Console.WriteLine("Result: Based on theory exams + practicals + viva.");
    }
}

// Polymorphism Demonstration
