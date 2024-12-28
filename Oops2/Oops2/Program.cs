class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Student regularStudent = new RegularStudent(101, "Alice", "Female", 20, "Arts", "City A");
        Student enggStudent = new EnggStudent(102, "Bob", "Male", 21, "Engineering", "City B");

        // Call methods
        regularStudent.AttendSession();
        regularStudent.WearIdCard();
        regularStudent.GiveExam();
        regularStudent.GetResult();

        Console.WriteLine();

        enggStudent.AttendSession();
        enggStudent.WearIdCard();
        enggStudent.GiveExam();
        ((EnggStudent)enggStudent).GivePractical(); // Casting for specific method
        enggStudent.GetResult();
    }
}