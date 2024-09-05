using Microsoft.AspNetCore.Mvc;

namespace HydraApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }
        public IActionResult AdminHomePage()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
