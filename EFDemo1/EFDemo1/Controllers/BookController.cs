using EFDemo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDemo1.Controllers
{
    public class BookController : Controller
    {
        private readonly BookCrud bookCrud;

        public BookController(ApplicationDbContext db)
        {
            this.bookCrud = new BookCrud(db);
        }

        // GET: BookController
        public ActionResult Index()
        {
            var response = bookCrud.GetAllBook();
            return View(response);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = bookCrud.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = bookCrud.AddBook(book);
                    if (result > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                return View(book);
            }
            catch
            {
                return View(book);
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = bookCrud.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = bookCrud.UpdateBook(book);
                    if (result > 0)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                return View(book);
            }
            catch
            {
                return View(book);
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = bookCrud.GetBookById(id);  
            if (book == null)
            {
                return NotFound();  
            }
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var result = bookCrud.DeleteBook(id);
                if (result > 0)  
                {
                    return RedirectToAction(nameof(Index));  
                }
                else
                {
                    
                    return RedirectToAction(nameof(Delete), new { id });
                }
            }
            catch
            {
                
                return RedirectToAction(nameof(Delete), new { id });
            }
        }
    }
}
