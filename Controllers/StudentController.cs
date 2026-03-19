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
    }
}
