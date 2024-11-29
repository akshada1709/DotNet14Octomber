using DIPatternDemo.Models;

namespace DIPatternDemo.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();

        Student GetStudentByRollNo(int rollno);

        int AddStudent(Student student);

        int UpdateStudent(Student student);

        int DeleteStudent(int rollno);
    }
}
