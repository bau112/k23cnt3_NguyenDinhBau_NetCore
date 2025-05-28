using Microsoft.AspNetCore.Mvc;

namespace Ndbday1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
