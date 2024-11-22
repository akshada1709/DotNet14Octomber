using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            ViewData["message"] = "Hello from controller";
            List<string> names = new List<string>() { "Akshada","Gayatri","Mayuri","Sneha"};

            ViewData["names"] = names; //object

            //list
            List<Employee> list = new List<Employee>() {
            
              new Employee{Id=101,Name="Akshada",Dept="Devlopment",Salary=30000},
               new Employee{Id=102,Name="Ankita",Dept="HR",Salary=60000},
                new Employee{Id=103,Name="Sonam",Dept="QA",Salary=50000},
                 new Employee{Id=104,Name="Megha",Dept="Finance",Salary=40000},
            };

            ViewData["emp"] = list;
            return View();
        }
    }
}
