//using System;
//using System.Collections.Generic;


//namespace CrudOpration
//{
//    public class MainStudent
//    {
////        static void Main(string[] args)
////        {
////            StudentCrud crud = new StudentCrud();
////            try
////            {
////                int a = 1;
////                do
////                {
////                    Console.WriteLine("1. Student List");
////                    Console.WriteLine("2. Add Student");
////                    Console.WriteLine("3. Modify Student");
////                    Console.WriteLine("4. Delete Student");
////                    Console.WriteLine("5. Get Student By Roll No");
////                    Console.WriteLine("Select option from above");
////                    int op = Convert.ToInt32(Console.ReadLine());

////                    switch (op)
////                    {
////                        case 1:
////                            List<Student> students = crud.StudentList();
////                            Console.WriteLine("RollNo  Name  Marks");
////                            foreach (var item in students)
////                            {
////                                Console.WriteLine(item);
////                            }
////                            break;
////                        case 2:
                            
////                            Student s1 = new Student();
                           
////                            Console.WriteLine("Enter Roll No");
////                            s1.RollNo = Convert.ToInt32(Console.ReadLine());
                            
////                            Console.WriteLine("Enter Name");
////                            s1.Name = Console.ReadLine();
                           
////                            Console.WriteLine("Enter Marks");
////                            s1.Marks = Convert.ToInt32(Console.ReadLine());
                           
////                            crud.AddStudent(s1);
////                            Console.WriteLine("Added the student");
////                            break;
////                        case 3:
                           
////                            Student s2 = new Student();
                           
////                            Console.WriteLine("Enter existing Roll No");
////                            s2.RollNo = Convert.ToInt32(Console.ReadLine());
                           
////                            Console.WriteLine("Enter new Name");
////                            s2.Name = Console.ReadLine();
                           
////                            Console.WriteLine("Enter new Marks");
////                            s2.Marks = Convert.ToInt32(Console.ReadLine());
////                            crud.ModifyStudent(s2);
                            
////                            Console.WriteLine("Updated the student");
////                            break;
////                        case 4:
                           
////                            Console.WriteLine("Enter existing Roll No to delete");
////                            int rollNo = Convert.ToInt32(Console.ReadLine());
                           
////                            crud.DeleteStudent(rollNo);
                           
////                            Console.WriteLine("Deleted the student");
////                            break;
////                        case 5:
                            
////                            Console.WriteLine("Enter existing Roll No");
////                            int rollNo2 = Convert.ToInt32(Console.ReadLine());
////                            Student s = crud.GetStudentById(rollNo2);
                           
////                            Console.WriteLine(s);
////                            break;
////                    }
////                    Console.WriteLine("Press 1 to continue or 0 to exit");
////                    a = Convert.ToInt32(Console.ReadLine());
////                }
////                while (a == 1);
////            }
////            catch (Exception ex)
////            {
////                Console.WriteLine(ex.Message);
////            }
////        }
////    }
////}
        
    

