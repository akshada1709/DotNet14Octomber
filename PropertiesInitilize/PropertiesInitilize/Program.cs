using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInitilize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Student student = new Student();
            //// for property inialize syntax
            //student.RollNo = 101;
            //student.Name = "Akshada";
            //student.Marks = 72;
            //Console.WriteLine($"Roll number is : {student.RollNo}/ name is : {student.Name}/marks is : {student.Marks}");

            ////Object initilizer syntax

            //Student student2 = new Student { RollNo=102,Name="Gayatri", Marks = 88};
            //Console.WriteLine($"Roll number is : {student2.RollNo}/ name is : {student2.Name}/marks is : {student2.Marks}");

            //// for property inialize syntax
            //Employee employee = new Employee();

            //employee.Eid = 1;
            //employee.EName = "Akshay";
            //employee.Salary = 22000;

            //Employee emp = new Employee { Eid = 2, EName = "Mohan", Salary = 40000 };
            //Console.WriteLine($"Employee information {emp.Eid}/{emp.EName}/{emp.Salary}");


            //Main method for Static Program


            //Main method for OverLoading Program
            MethodOverLoading ml=new MethodOverLoading();
           
           

            Console.WriteLine($" Addition of number is {ml.Addition(12,34)}");
            Console.WriteLine($" Addition of number is { ml.Substraction(10, 4, 5)}");
            Console.WriteLine($" Addition of number is {ml.Multiplication(1, 4, 5)}");
        }
    }
}
