using DIPatternDemo1.Models;
using DIPatternDemo1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIPatternDemo1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService service;
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment env;
        private readonly ICategoryService cat;


        public ProductController(IProductService service, Microsoft.AspNetCore.Hosting.IHostingEnvironment env,ICategoryService cat) 
        {
          this.service = service;
            this.env = env;
            this.cat = cat;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(service.GetProducts());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.Categories=cat.GetCategories();
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product prod, IFormFile file)
        {
            try
            {
                if (file != null && file.Length > 0)
                {
                    string filePath = Path.Combine(env.WebRootPath, "images", file.FileName);

                    // Save the file
                    using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fs);
                    }

                    // Set the product's image URL
                    prod.ImageUrl = "~/images/" + file.FileName;

                    // Add product to the service
                    service.AddProduct(prod);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(prod);
            }
        }


        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Categories = cat.GetCategories();
            var prod = service.GetProductById(id);
            TempData["oldUrl"] = prod.ImageUrl;
            TempData.Keep("oldUrl");
            return View(prod);

        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
