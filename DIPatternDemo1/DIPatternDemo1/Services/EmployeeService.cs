﻿using DIPatternDemo1.Models;
using DIPatternDemo1.Repositories;

namespace DIPatternDemo1.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;

        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        public int AddEmployee(Employee employee)
        {
           return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
           return repo.DeleteEmployee(id);
        }

        public Employee GetEmployeeById(int id)
        {
           return repo.GetEmployeeById(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public int UpdateEmployee(Employee employee)
        {
           return repo.UpdateEmployee(employee);
        }
    }
}
