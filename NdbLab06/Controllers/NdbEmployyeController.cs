using Microsoft.AspNetCore.Mvc;
using NdbLab06.Models;

namespace NdbLab06.Controllers
{
    public class NdbEmployyeController : Controller
    {
        private static List<NdbEmployee> NdbListEmployee = new List<NdbEmployee> ()
            {
        new NdbEmployee { NdbId = 1, NdbName = "Nguyễn Đình Báu", NdbBirthDay = new DateTime(2005, 10, 12), NdbEmail = "Ndb1134@gmail.com", NdbPhone = "0123456789", NdbSalary = 12000000, NdbStatus = true },
        new NdbEmployee { NdbId = 2, NdbName = "Trần Thị B", NdbBirthDay = new DateTime(1985, 5, 15), NdbEmail = "b@gmail.com", NdbPhone = "0987654321", NdbSalary = 15000000, NdbStatus = true },
        new NdbEmployee { NdbId = 3, NdbName = "Lê Văn C", NdbBirthDay = new DateTime(1993, 3, 20), NdbEmail = "c@gmail.com", NdbPhone = "0345678912", NdbSalary = 9000000, NdbStatus = false },
        new NdbEmployee { NdbId = 4, NdbName = "Đỗ Thị D", NdbBirthDay = new DateTime(1998, 7, 8), NdbEmail = "d@gmail.com", NdbPhone = "0456789123", NdbSalary = 11000000, NdbStatus = true },
        new NdbEmployee { NdbId = 5, NdbName = "Sinh Viên X", NdbBirthDay = new DateTime(2002, 9, 25), NdbEmail = "svx@student.edu.vn", NdbPhone = "0555566667", NdbSalary = 0, NdbStatus = false }
            };
        public IActionResult NdbIndex()
        {
            return View(NdbListEmployee);
        }
        public IActionResult NdbCreate()
        {
            return View();
        }
        public IActionResult ndbCreate(NdbEmployee model)
        {
            if (ModelState.IsValid)
            {
                int newId = NdbListEmployee.Any() ? NdbListEmployee.Max(e => e.NdbId) + 1 : 1;
                model.NdbId = newId;

                NdbListEmployee.Add(model);

                return RedirectToAction("NdbIndex");
            }
            return View(model);
        }
    }
}
