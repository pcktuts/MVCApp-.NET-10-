using Microsoft.AspNetCore.Mvc;
using MVCApp.Model;

namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student { Name= "John"},
                new Student { Name = "Sara"}
            };
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            return RedirectToAction("Index");
        }
    }
}
