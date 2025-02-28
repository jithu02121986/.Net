using Microsoft.AspNetCore.Mvc;

namespace AccountDetailsWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
