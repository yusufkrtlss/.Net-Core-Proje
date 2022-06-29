using BusinessLayer.BlogServices;
using InternshipProjectDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InternshipProjectDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogService _blog;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; 

        }

        public IActionResult Create()
        {
            var Model = new WriterDetailsModel();
            //writer = _writer.getById(5)
            //pictures = _pictur.getall(5,Type.Writer)
            Model.Writer = null;
            Model.Pictures = null;
                return View(Model);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}