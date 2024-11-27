using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace WebApplicationDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]//this is opstion by default is get method
        public IActionResult PersonDetails()
        {
            List<string> cities = new List<string>() { "Pune", "Nagpur", "Mumbai", "Surat" };
            ViewData["cities"]=new SelectList(cities);
            return View();
        }

        [HttpPost]
        public IActionResult PersonDetails(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Email = form["email"];
            ViewBag.City = form["cities"];
            return View("display");
        }

    }
}
