using Microsoft.AspNetCore.Mvc;

namespace AccountDetailsWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
