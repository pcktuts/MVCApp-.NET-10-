using Microsoft.AspNetCore.Mvc;
using MVCApp.Data;
using MVCApp.Model;

namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            TempData["message"] = "Student added successfully!";
            return RedirectToAction("Index");
        }
    }
}
