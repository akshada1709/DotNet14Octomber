using RESTDemo.Models;

namespace RESTDemo.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int rollNo);
        IEnumerable<Student> GetStudentByBranch(string branch);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int rollNo);
    }
}
