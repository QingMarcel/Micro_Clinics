using Microsoft.AspNetCore.Mvc;

namespace MicroClinic.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RegisterPatient()
        {
            return View();
        }

        public IActionResult RegisterDoctor()
        {
            return View();
        }
    }
}
