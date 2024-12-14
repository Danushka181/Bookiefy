using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Load the home page view
        public IActionResult Index()
        {
            return View();
        }

        // Load the privacy page view
        public IActionResult Privacy()
        {
            return View();
        }


        // Load the error page view
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}