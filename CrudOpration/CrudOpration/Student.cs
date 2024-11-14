//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CrudOpration
//{
//    public class Student
//    {
//        public int RollNo { get; set; }
//        public string Name { get; set; }
//        public int Marks {  get; set; }

//        public override string ToString()
//        {
//            return $"RollNo={RollNo},Name={Name},Marks{Marks}";
//        }
//    }

//    //manage Student

//    public class StudentCrud 
//    {
    
//        //we have n numbers of student i.e we use list,store n numbers of Students
//        List<Student> students;

//        public StudentCrud() 
//        {
//           students = new List<Student>();//list is empty
//        }

//        public void AddStudent(Student std) //pass student obj because we add in student
//        {
//          students.Add(std);
//        }

//        public void ModifyStudent(Student std) 
//        {
//            for (int i = 0; i < students.Count; i++) 
//            {
//                if (students[i].RollNo == std.RollNo) 
//                {
//                    students[i].Name=std.Name;
//                    students[i].Marks = std.Marks;
//                    break;
//                }
//            }
//        }

//        public void DeleteStudent(int rollno) 
//        {

//            for (int i = 0; i < students.Count; i++) 
//            {
//                if (students[i].RollNo == rollno) 
//                {
//                   students.Remove(students[i]);
//                   //students.RemoveAt(i);
//                }
//            }
//        }
//        public List<Student> StudentList() 
//        { 
//            return students;
//        }

//        //public Student GetStudentById(int rollno1)
//        //{
//        //    //create product to hold data
//        //    Student s = new Student();
//        //    foreach (var item in students)
//        //    {
//        //        if (item.RollNo == rollno1)
//        //        {
//        //           s.RollNo=item.RollNo;
//        //            s.Name=item.Name;
//        //            s.Marks = item.Marks;
//        //            break;
//        //        }

//        //    }
//        //    return s;
//        //}

//    }
//}
