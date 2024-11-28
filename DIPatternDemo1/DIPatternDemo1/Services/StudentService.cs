using DIPatternDemo1.Models;
using DIPatternDemo1.Repositories;

namespace DIPatternDemo1.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;

        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student std)
        {
            return repo.AddStudent(std);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public IEnumerable<Student> GetStudent()
        {
           return repo.GetStudent();
        }

        public Student GetStudentByRollNo(int id)
        {
            return repo.GetStudentByRollNo(id);
        }

        public int UpdateStudent(Student std)
        {
           return repo.UpdateStudent(std);
        }
    }
}
