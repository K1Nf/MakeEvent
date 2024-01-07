using MakeEvent.Context;
using MakeEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MakeEvent.Controllers
{
    public class EventController : Controller
    {
        private readonly ILogger<EventController> _logger;
        private readonly AppDbContext _context;

        public EventController(ILogger<EventController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult EventPage(int? Id)
        {
            return View(FindElem(Id));
        }
        public IActionResult Delete(int? Id)
        {
            return View(FindElem(Id));
        }
        public IActionResult Update(int? Id)
        {
            return View(FindElem(Id));
        }
        public IActionResult Create()
        {
            return View();
        }

        private Event? FindElem(int? Id)
        {
            return _context.events.Find(Id);
        }
    }
}
