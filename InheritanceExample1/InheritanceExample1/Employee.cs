//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace InheritanceExample1
//{
//    public class Employee
//    {
//        protected int id;
//        protected string name;
//        protected double basic, hra, da, pf, gross;
//        private static int count;
//        protected Date date; // containment

//        // Constructor
//        public Employee(string nm, double bs, Date date)
//        {
//            count++;
//            id = count;
//            name = nm;
//            basic = bs;
//            this.date = date;
//        }

//        // Calculate employee salary
//        public virtual void CalculateSalary()
//        {
//            hra = basic * 0.40; // 40% of basic salary
//            da = basic * 0.20;
//            pf = basic * 0.12;
//            gross = (basic + hra + da) - pf;
//        }

//        // Display employee details
//        public override string ToString()
//        {
//            return $"Id = {id} , Name = {name}, Gross Salary = {gross}, Joining Date = {date.DisplayDate()}";
//        }

//        // Static method to get the employee count
//        public static int EmpCount()
//        {
//            return count;
//        }
//    }
//}