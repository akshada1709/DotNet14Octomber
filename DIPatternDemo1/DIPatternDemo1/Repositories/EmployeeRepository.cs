using DIPatternDemo1.Data;
using DIPatternDemo1.Models;

namespace DIPatternDemo1.Repositories
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
            db.Empoyees.Add(employee);
            db.SaveChanges();
            return result;

        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
            var emp=db.Empoyees?.Where(x=>x.EmpId==id).SingleOrDefault();
            if (emp != null) 
            {
                db.Empoyees?.Remove(emp);
                result=db.SaveChanges();
            
            }
            return result;

        }

        public Employee GetEmployeeById(int id)
        {
            return db.Empoyees.Where(x => x.EmpId == id).SingleOrDefault();

        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Empoyees.ToList();
        }

        public int UpdateEmployee(Employee employee)
        {
            int result = 0;
            var emp = db.Empoyees?.Where(x => x.EmpId == employee.EmpId).SingleOrDefault();
            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Email = employee.Email;
                emp.Salary = employee.Salary;
                result = db.SaveChanges();
            }
            return result;

        }
    }
}
