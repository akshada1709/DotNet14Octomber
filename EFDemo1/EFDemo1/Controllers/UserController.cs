using EFDemo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDemo1.Controllers
{
    public class UserController : Controller
    {
        private readonly UserOpration userOpration; // Corrected field name

      
        public UserController(ApplicationDbContext db)
        {
            this.userOpration=new UserOpration(db);
        }

      
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            try
            {
             
                var validatedUser = userOpration.Validate(user);

                if (validatedUser != null)
                {
                    
                    return RedirectToAction(nameof(Index));  
                }
                else
                {
                   
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(user); 
                }
            }
            catch
            {
                return View();
            }
        }

        
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                    var result = userOpration.AddUser(user);

                    if (result > 0) 
                    {
                     
                        return RedirectToAction(nameof(Login)); 
                    }
                    else
                    {
                        
                        ModelState.AddModelError(string.Empty, "User with this email already exists.");
                        return View(user); 
                    }
                }
                return View(user); 
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Index()
        {
            return View(); 
        }
    }
}
