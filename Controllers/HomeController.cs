using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TESTOWE.Models;

namespace TESTOWE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string searchString)
        {
            // Przykładowe dane
            var programs = new List<ProgramInfo>
            {
                new ProgramInfo { Name = "LanSweeper", Description = "Program do zarządzania zasobami IT." },
                new ProgramInfo { Name = "MS Word", Description = "Edytor tekstu od Microsoft." }
            };


           

            return View(programs);
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