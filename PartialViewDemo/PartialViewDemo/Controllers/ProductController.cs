using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductController(ApplicationDbContext applicationDbContext) 
        {
           this.applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
           var model=applicationDbContext.Products.ToList();
            return View(model);
        }
    }
}
