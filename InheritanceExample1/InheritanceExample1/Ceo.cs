//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InheritanceExample1
//{
//    public class Ceo : Employee
//    {
//        public class Ceo : Employee
//        {
//            private double incentives;

//            // Constructor
//            public Ceo(string nm, double basic, Date date, double incentives) : base(nm, basic, date)
//            {
//                this.incentives = incentives;
//            }

//            // Method overriding for CEO salary calculation
//            public override void CalculateSalary()
//            {
//                hra = basic * 0.50;
//                da = basic * 0.30;
//                pf = basic * 0.10;
//                gross = (basic + hra + da + incentives) - pf;
//            }

//            // Display CEO details
//            public override string ToString()
//            {
//                return $"CEO details: Id = {id}, Name = {name}, Gross Salary = {gross}, Incentives = {incentives}, Joining Date = {date.DisplayDate()}";
//            }
//        }
//    }
//}