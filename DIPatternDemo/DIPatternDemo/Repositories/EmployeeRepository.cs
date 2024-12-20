﻿using DIPatternDemo.Data;
using DIPatternDemo.Models;

namespace DIPatternDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;

        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddEmployee(Employee employee)
        {
            int result = 0;
            db.Employees?.Add(employee);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
           int result = 0;
           var emp = db.Employees?.Where(x => x.EmpId == id).SingleOrDefault();
            if(emp != null)
            {
                db.Employees?.Remove(emp);
                result=db.SaveChanges();
            }
            return result;
        }

        public Employee GetEmployeeById(int id)
        {
            return db.Employees?.Where(x => x.EmpId == id).SingleOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees?.ToList();
        }

        public int UpdateEmployee(Employee employee)
        {
            int result = 0;
            
            var e = db.Employees?.Where(x => x.EmpId == employee.EmpId).SingleOrDefault();
            if (e != null)
            {
                
                e.Name = employee.Name;
                e.Email = employee.Email;
                e.Salary = employee.Salary;
                
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
