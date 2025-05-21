using Lesson05Model.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson05Model.Controllers
{
    public class NdbMemberController : Controller
    {
        // Danh sách thành viên mẫu
        private static List<NdbMember> ndbMemberList = new List<NdbMember>
        {
            new NdbMember
            {
                NdbMemberID = Guid.NewGuid().ToString(),
                NdbUsername = "123",
                NdbFullname = "Nguyen Dinh Bau",
                NdbPassword = "12345678",
                NdbEmail = "Ndb1134@gmail.com"
            },
            new NdbMember
            {
                NdbMemberID = Guid.NewGuid().ToString(),
                NdbUsername = "007",
                NdbFullname = "Tran Thi A",
                NdbPassword = "pass132",
                NdbEmail = "user132@example.com"
            },
            new NdbMember
            {
                NdbMemberID = Guid.NewGuid().ToString(),
                NdbUsername = "063",
                NdbFullname = "Le Van B",
                NdbPassword = "pass67",
                NdbEmail = "user06@example.com"
            },
            new NdbMember
            {
                NdbMemberID = Guid.NewGuid().ToString(),
                NdbUsername = "004",
                NdbFullname = "Pham Thi K",
                NdbPassword = "pass04",
                NdbEmail = "user05@example.com"
            },
            new NdbMember
            {
                NdbMemberID = Guid.NewGuid().ToString(),
                NdbUsername = "067",
                NdbFullname = "Hoang Van H",
                NdbPassword = "pass66",
                NdbEmail = "user078@example.com"
            }
        };

        // Trang hiển thị danh sách thành viên
        public IActionResult NdbIndex()
        {
            return View(ndbMemberList); // truyền danh sách sang View
        }
    }
}
