using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();

        Student GetStudentByRollNo(int rollno);

        int AddStudent(Student student);

        int UpdateStudent(Student student);

        int DeleteStudent(int rollno);
    }
}
