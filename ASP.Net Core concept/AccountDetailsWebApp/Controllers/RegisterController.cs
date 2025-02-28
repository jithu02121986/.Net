using Microsoft.AspNetCore.Mvc;

namespace AccountDetailsWebApp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
