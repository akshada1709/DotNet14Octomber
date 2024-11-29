using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
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
            int result = 0;
            db.Students?.Add(student);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int rollno)
        {
            int result = 0;
            var stud = db.Students?.Where(x => x.StdRollNo == rollno).SingleOrDefault();
            if (stud != null)
            {
                db.Students?.Remove(stud);
                result = db.SaveChanges();
            }
            return result;
        }

        public Student GetStudentByRollNo(int rollno)
        {
            return db.Students?.Where(x => x.StdRollNo == rollno).SingleOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students?.ToList();
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;

            var s = db.Students?.Where(x => x.StdRollNo == student.StdRollNo).SingleOrDefault();
            if (s != null)
            {

                s.StdName = student.StdName;
                s.StdBranch = student.StdBranch;
                s.StdPercentage = student.StdPercentage;

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
