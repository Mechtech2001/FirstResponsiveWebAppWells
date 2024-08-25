using FirstResponsiveWebAppWells.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstResponsiveWebAppWells.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = model.AgeThisYear();
            }
            else
            {
                ViewBag.Age = 0;
            }
            
            return View(model);
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
    }
}
