using Microsoft.AspNetCore.Mvc;

namespace MakeEvent.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Account()
        {
            return View();
        }
    }
}
