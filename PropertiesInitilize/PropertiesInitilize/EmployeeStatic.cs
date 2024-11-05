using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInitilize
{
    public class EmployeeStatic
    {
        private int eid;
        private string ename;
        private int salary;
        private static int count;

        static EmployeeStatic()
            {
            count = 0;

            }
        public EmployeeStatic(int eid, string ename, int salary)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
        }
    }
}
