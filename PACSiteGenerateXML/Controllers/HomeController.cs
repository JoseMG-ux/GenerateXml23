using Microsoft.AspNetCore.Mvc;
using PACSiteGenerateXML.Models;
using System.Diagnostics;

namespace PACSiteGenerateXML.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Modal()
        {
            return View();
        }

        public IActionResult ViewOpInterna()
        {
            return View();
        }

        public IActionResult ViewInfoEmisor()
        {
            return View();
        }
        
        public IActionResult ViewInfoReceptor()
        {
            return View();
        }

        public IActionResult ViewRegistrarItem()
        {
            return View();
        }

        public IActionResult ViewInfoItem()
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
    }
}