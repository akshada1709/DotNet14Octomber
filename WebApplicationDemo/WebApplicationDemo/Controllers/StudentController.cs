using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetails()
        {
            List<string> branch = new List<string> { "CSE", "ECE", "Mechanical" };
            ViewData["branch"] = new SelectList(branch);
            return View();
        }

        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form)
        {
            ViewBag.RollNo = form["rollNo"];
            ViewBag.Name = form["name"];
            ViewBag.Branch = form["branch"];
            ViewBag.Year = form["passOut"];
            return View("Display Student Details");
        }
    }
}
