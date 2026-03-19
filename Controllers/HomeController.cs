using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string About() {
            return "This is about page";
        }
    }
}
