using DIPatternDemo.Models;
using DIPatternDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIPatternDemo.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Register(user);
                    return RedirectToAction("Login");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = service.Login(email, password);
            if (user != null)
            {
                // Store user info in session
                HttpContext.Session.SetString("UserId", user.UserId.ToString());
                HttpContext.Session.SetString("UserEmail", user.Email);

                // Set a cookie for a persistent login (optional)
                if (Request.Form["RememberMe"] == "on")
                {
                    var cookieOptions = new CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(30)
                    };
                    Response.Cookies.Append("UserEmail", user.Email, cookieOptions);
                }

                TempData["Success"] = "Login successful!";
                return RedirectToAction("Index", "Product");
            }

            ModelState.AddModelError("", "Invalid email or password.");
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            // Clear session and cookies
            HttpContext.Session.Clear();
            Response.Cookies.Delete("UserEmail");
            return RedirectToAction("Login");
        }
    }
}