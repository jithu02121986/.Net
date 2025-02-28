using Microsoft.AspNetCore.Mvc;

namespace FirstMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is index action from MVC controller";
        }
    }
}
