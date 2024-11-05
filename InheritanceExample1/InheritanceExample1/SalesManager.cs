//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InheritanceExample1
//{
//    public class SalesManager : Employee
//    {
//        public class SalesManager : Employee
//        {
//            private double bonus, comm;

//            // Constructor
//            public SalesManager(string nm, double basic, Date date, double bonus, double comm) : base(nm, basic, date)
//            {
//                this.bonus = bonus;
//                this.comm = comm;
//            }

//            // Method overriding for Sales Manager salary calculation
//            public override void CalculateSalary()
//            {
//                hra = basic * 0.30;
//                da = basic * 0.25;
//                pf = basic * 0.12;
//                gross = (basic + hra + da + bonus + comm) - pf;
//            }

//            // Display Sales Manager details
//            public override string ToString()
//            {
//                return $"Sales Manager details: Id = {id}, Name = {name}, Gross Salary = {gross}, Bonus = {bonus}, Commission = {comm}, Joining Date = {date.DisplayDate()}";
//            }
//        }
//    }
//}