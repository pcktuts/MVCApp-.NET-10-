using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello world from Action Index";
        }
        public string About() {
            return "This is about page";
        }
    }
}
