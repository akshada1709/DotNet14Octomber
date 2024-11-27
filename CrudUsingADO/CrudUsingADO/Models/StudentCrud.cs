using Microsoft.Data.SqlClient;

namespace CrudUsingADO.Models
{
    public class StudentCrud
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private IConfiguration configuration;

        public StudentCrud(IConfiguration configuration)
        {
            this.configuration = configuration;
            con = new SqlConnection(this.configuration.GetConnectionString("DefaultConnection"));
        }

        // Get all students
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            cmd = new SqlCommand("select * from student1", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Student student = new Student
                    {
                        RollNo = Convert.ToInt32(dr["rollNo"]),
                        Name = dr["name"].ToString(),
                        Percentage = Convert.ToInt32(dr["percentage"]),
                        Branch = dr["branch"].ToString()
                    };
                    students.Add(student);
                }
            }
            con.Close();
            return students;
        }

        // Get student by RollNo
        public Student GetStudentByRollNo(int rollNo)
        {
            Student student = new Student();
            cmd = new SqlCommand("select * from student1 where rollNo = @rollNo", con);
            cmd.Parameters.AddWithValue("@rollNo", rollNo);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    student.RollNo = Convert.ToInt32(dr["rollNo"]);
                    student.Name = dr["name"].ToString();
                    student.Percentage = Convert.ToInt32(dr["percentage"]);
                    student.Branch = dr["branch"].ToString();
                }
            }
            con.Close();
            return student;
        }

        // Add student
        public int AddStudent(Student student)
        {
            string query = "insert into student1 (name, percentage, branch) values (@name, @percentage, @branch)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", student.Name);
            cmd.Parameters.AddWithValue("@percentage", student.Percentage);
            cmd.Parameters.AddWithValue("@branch", student.Branch);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        // Update student
        public int UpdateStudent(Student student)
        {
            string query = "update student1 set name = @name, percentage = @percentage, branch = @branch where rollNo = @rollNo";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", student.Name);
            cmd.Parameters.AddWithValue("@percentage", student.Percentage);
            cmd.Parameters.AddWithValue("@branch", student.Branch);
            cmd.Parameters.AddWithValue("@rollNo", student.RollNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        // Delete student
        public int DeleteStudent(int rollNo)
        {
            string query = "delete from student1 where rollNo = @rollNo";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@rollNo", rollNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}
