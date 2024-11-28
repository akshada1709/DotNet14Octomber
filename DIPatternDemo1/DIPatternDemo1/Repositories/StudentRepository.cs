using DIPatternDemo1.Data;
using DIPatternDemo1.Models;

namespace DIPatternDemo1.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student std)
        {
            int result = 0;
            db.Students.Add(std);
            db.SaveChanges();
            return result;

        }

        public int DeleteStudent(int rollno)
        {
            int result = 0;
            var std = db.Students?.Where(x => x.RollNo == rollno).SingleOrDefault();
            if (std != null)
            {
                db.Students?.Remove(std);
                result = db.SaveChanges();

            }
            return result;
        }

        public IEnumerable<Student> GetStudent()
        {
            return db.Students.ToList();
        }

        public Student GetStudentByRollNo(int rollno)
        {
           
            var student = db.Students?.Where(x => x.RollNo == rollno).SingleOrDefault();

            if (student != null)
            {
               
                int? percentage = student.Percentage; 
            }

            return student;
        }
        public int UpdateStudent(Student std)
        {
            int result = 0;
            var st = db.Students?.Where(x => x.RollNo == std.RollNo).SingleOrDefault();
            if (std != null)
            {
                st.RollNo=std.RollNo;
                st.Name=std.Name;
                st.Percentage=std.Percentage;
                st.Branch=std.Branch;

            }
            return result;
        }
    }
}
