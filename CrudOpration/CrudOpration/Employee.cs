using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOpration
{
    //Entity class
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Id={Id},Name={Name},Salary{Salary}";
        }
    }

    //manage Employee

    public class EmployeeCrud
    {
        List<Employee> list;

        public EmployeeCrud()
        {
            list = new List<Employee>();

        }

        public void AddEmployee(Employee emp) //pass Employee obj because we add in Employee
        {
            list.Add(emp);
        }

        public void ModifyEmployee(Employee emp)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == emp.Id)
                {
                    list[i].Name = emp.Name;
                    list[i].Salary = emp.Salary;
                    break;

                }
            }
        }

        public void DeleteEmployee(int id)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list.Remove(list[i]);
                    //list.RemoveAt(i);
                }
            }
        }

        //return list so method return data-type is list data-type i.e List<Employee>
        public List<Employee> EmployeeList()
        {
            return list;
        }

        public Employee GetEmployeeById(int id)
        {
            //create product to hold data
            Employee e = new Employee();
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    e.Id = item.Id;
                    e.Name = item.Name;
                    e.Salary = item.Salary;
                    break;
                }

            }
            return e;
        }
    }
}
