using Microsoft.AspNetCore.Mvc;

namespace LandingPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            TempData["Message"] = "Thank you for reaching out! We'll get back to you soon.";
            return RedirectToAction("Index");
        }
    }
}
