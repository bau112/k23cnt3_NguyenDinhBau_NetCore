using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ndb_2310900011.Models;

namespace Ndb_2310900011.Controllers
{
    public class NdbHomeController : Controller
    {
        private readonly ILogger<NdbHomeController> _logger;

        public NdbHomeController(ILogger<NdbHomeController> logger)
        {
            _logger = logger;
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
    }
}
