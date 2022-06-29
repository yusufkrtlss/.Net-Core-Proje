using Microsoft.AspNetCore.Mvc;

namespace InternshipProjectDemo.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
