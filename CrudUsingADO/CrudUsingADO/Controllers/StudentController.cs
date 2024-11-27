using Microsoft.AspNetCore.Mvc;
using CrudUsingADO.Models;

namespace CrudUsingADO.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentCrud _studentCrud;

        // Inject the configuration to initialize StudentCrud class
        public StudentController(IConfiguration configuration)
        {
            _studentCrud = new StudentCrud(configuration);
        }

        // Get all students - Index page
        public IActionResult Index()
        {
            var students = _studentCrud.GetStudents();
            return View(students); // Return students list to the view
        }

        // Get student by RollNo for Details page
        public IActionResult Details(int rollNo)
        {
            var student = _studentCrud.GetStudentByRollNo(rollNo); // Get student by RollNo
            if (student == null)
            {
                return NotFound(); // Return NotFound if student is not found
            }
            return View(student); // Return student details to the view
        }

        // Get student by RollNo for Edit page
        public IActionResult Edit(int rollNo)
        {
            var student = _studentCrud.GetStudentByRollNo(rollNo);
            if (student == null)
            {
                return NotFound(); // Return NotFound if student is not found
            }
            return View(student); // Return student details to the view for editing
        }

        // Post method for editing student details
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int rollNo, Student student)
        {
            if (rollNo != student.RollNo)
            {
                return NotFound(); // Ensure rollNo matches before proceeding
            }

            if (ModelState.IsValid)
            {
                // Call the update method
                var result = _studentCrud.UpdateStudent(student);
                if (result > 0)
                {
                    return RedirectToAction(nameof(Index)); // Redirect to Index page if update is successful
                }
                else
                {
                    ModelState.AddModelError("", "Unable to update student details."); // Show error if update fails
                }
            }
            return View(student); // Return the student object to the view in case of invalid model or error
        }

        // Get student by RollNo for Delete confirmation page
        public IActionResult Delete(int rollNo)
        {
            var student = _studentCrud.GetStudentByRollNo(rollNo);
            if (student == null)
            {
                return NotFound(); // Return NotFound if student is not found
            }
            return View(student); // Return student details for deletion confirmation
        }

        // Post method for deleting student
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int rollNo)
        {
            var result = _studentCrud.DeleteStudent(rollNo); // Delete student by RollNo
            if (result > 0)
            {
                return RedirectToAction(nameof(Index)); // Redirect to Index page if deletion is successful
            }
            return View(); // Return to delete confirmation page if delete fails
        }
    }
}
