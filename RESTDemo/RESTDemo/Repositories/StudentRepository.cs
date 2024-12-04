using RESTDemo.Data;
using RESTDemo.Models;

namespace RESTDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddStudent(Student student)
        {
            int result;
            db.Students?.Add(student);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int rollNo)
        {
            int result = 0;
            var s = db.Students?.Where(x => x.rollNo == rollNo).FirstOrDefault();
            if (s != null)
            {
                db.Students?.Remove(s);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Student> GetStudentByBranch(string branch)
        {
            var model = db.Students?.Where(x => x.branch.Contains(branch)).ToList();
            return model;
        }

        public Student GetStudentById(int rollNo)
        {
            return db.Students?.Where(x => x.rollNo == rollNo).FirstOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
            var s = db.Students?.Where(x => x.rollNo == student.rollNo).FirstOrDefault();
            if (s != null)
            {
                db.Entry<Student>(s).CurrentValues.SetValues(student);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}