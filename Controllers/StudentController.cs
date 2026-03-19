using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
