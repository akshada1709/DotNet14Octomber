using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInitilize
{
    public class Employee
    {
        private int eid;
        private string ename;
        private double salary;

        public int Eid
        {
            set { eid = value; }
            get { return Eid; }
        }

        public String EName
        {
            set { ename= value; }
            get { return ename; }
        }
        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }
    }

    
}
