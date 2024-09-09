using Microsoft.AspNetCore.Mvc;

namespace HydraApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin Login page
        public IActionResult AdminLogin()
        {
            return View();
        }

        // POST: Admin Login form submission
        [HttpPost]
        public IActionResult AdminLogin(string username, string password)
        {
            // Dummy validation logic for demonstration purposes
            if (username == "admin" && password == "1234")
            {
                // If credentials are valid, set session
                HttpContext.Session.SetString("IsAdminLoggedIn", "true");

                // Redirect to AdminHomePage
                return RedirectToAction("AdminHomePage");
            }
            else
            {
                // If login fails, show error message
                ViewBag.ErrorMessage = "Invalid username or password";
                return View();
            }
        }

        // GET: Admin Home Page
        public IActionResult AdminHomePage()
        {
            // Check if the session indicates admin is logged in
            var isLoggedIn = HttpContext.Session.GetString("IsAdminLoggedIn");

            if (string.IsNullOrEmpty(isLoggedIn) || isLoggedIn != "true")
            {
                // If not logged in, redirect to login page
                return RedirectToAction("AdminLogin");
            }

            return View();
        }

        // GET: Forgot Password page
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
