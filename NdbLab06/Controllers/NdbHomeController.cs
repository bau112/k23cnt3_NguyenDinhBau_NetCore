using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NdbLab06.Models;

namespace NdbLab06.Controllers
{
    public class NdbHomeController : Controller
    {
        private readonly ILogger<NdbHomeController> _logger;

        public NdbHomeController(ILogger<NdbHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NdbIndex()
        {
            return View();
        }

        public IActionResult NdbAbout()
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
