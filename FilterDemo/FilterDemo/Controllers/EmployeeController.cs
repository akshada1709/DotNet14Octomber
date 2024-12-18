using Microsoft.AspNetCore.Mvc;

namespace FilterDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeList()
        {
            return View();
        }
    }
}
