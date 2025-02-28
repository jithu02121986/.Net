using Microsoft.AspNetCore.Mvc;

namespace AccountDetailsWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
