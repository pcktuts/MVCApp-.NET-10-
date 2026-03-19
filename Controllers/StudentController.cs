using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<string> { "John", "Sara" };
            return View(students);
        }
    }
}
