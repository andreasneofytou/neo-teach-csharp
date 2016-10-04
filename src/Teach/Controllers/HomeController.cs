using Microsoft.AspNetCore.Mvc;
using Teach.Database;
using Microsoft.AspNetCore.Authorization;

namespace Teach.Controllers {
    [Authorize]
    public class HomeController : Controller {
        private TeachDbContext _context;
        public HomeController(TeachDbContext context) {
            _context = context;
        }
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error() {
            return View();
        }
    }
}
