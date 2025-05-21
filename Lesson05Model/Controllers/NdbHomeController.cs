using Lesson05Model.Models.DataModels;
using Lesson05Model.Models;
using Microsoft.AspNetCore.Mvc;
using Lesson05Model.Models;
using Lesson05Model.Models.DataModels;
using System.Diagnostics;

namespace nthLesson5.Controllers
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
            var member = new NdbMember
            {
                NdbMemberID = Guid.NewGuid().ToString(),
                NdbUsername = "Bau123",
                NdbFullname = "Nguyen Dinh Bau",
                NdbPassword = "123456789", // Không nên dùng plain text trong thực tế
                NdbEmail = "ndb1134@gmail.com"
            };

            return View(member); // Trả về model kiểu mạnh
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
