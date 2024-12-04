using RESTDemo.Models;
using RESTDemo.Repositories;

namespace RESTDemo.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository repo;

        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }

        public int AddStudent(Student student)
        {
            return repo.AddStudent(student);
        }

        public int DeleteStudent(int rollNo)
        {
            return repo.DeleteStudent(rollNo);
        }

        public IEnumerable<Student> GetStudentByBranch(string branch)
        {
            return repo.GetStudentByBranch(branch);
        }

        public Student GetStudentById(int rollNo)
        {
            return repo.GetStudentById(rollNo);
        }

        public IEnumerable<Student> GetStudents()
        {
            return repo.GetStudents();
        }

        public int UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }
    }
}