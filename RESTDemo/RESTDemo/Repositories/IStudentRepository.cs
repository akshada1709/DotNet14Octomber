using RESTDemo.Models;

namespace RESTDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int rollNo);
        IEnumerable<Student> GetStudentByBranch(string branch);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int rollNo);
    }
}
