using CrudUsingADO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudUsingADO.Controllers
{
    public class EmplyeeController : Controller
    {
        private readonly IConfiguration configuration;
        EmployeeCrud db;

        public EmplyeeController(IConfiguration configuration) 
        {
           this.configuration = configuration;
            db=new EmployeeCrud(this.configuration);
        }

        // All Employee
        public ActionResult Index()
        {
            var response=db.GetEmployees();
            return View(response);
           
        }

        // GET: EmplyeeController/Details/5
        public ActionResult Details(int id)
        {
            var res = db.GetEmployeeById(id);
            return View(res);
        }

        // GET: EmplyeeController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: EmplyeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                int response=db.AddEmployee(emp);
                if (response >= 1) 
                {
                    return RedirectToAction(nameof(Index));
                }
                else 
                {
                    ViewBag.ErrorMsg = "Something went wrong";
                    return View();
                }
             
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMsg=ex.Message;
                return View();
            }
        }

        // GET: EmplyeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var res = db.GetEmployeeById(id);
            return View(res);
                        
        }

        // POST: EmplyeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                int response = db.UpdateEmployee(emp);
                if (response >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMsg = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }

        // GET: EmplyeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var res = db.GetEmployeeById(id);
            return View(res);
        }

        // POST: EmplyeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")] //this inform to clr that DeleteConfirm is the Httpost method againt delete
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int response = db.DeleteEmployee(id);
                if (response >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMsg = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }
    }
}
