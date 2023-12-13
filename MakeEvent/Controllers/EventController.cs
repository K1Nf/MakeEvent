using Microsoft.AspNetCore.Mvc;

namespace MakeEvent.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult EventPage()
        {
            return View();
        }
    }
}
