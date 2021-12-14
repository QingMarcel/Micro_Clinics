using Microsoft.AspNetCore.Mvc;

namespace MicroClinic.Controllers
{
    public class SecuredController : Controller
    {
        public IActionResult Patient()
        {
            return View();
        }

        public IActionResult Doctor()
        {
            return View();
        }
    }
}
