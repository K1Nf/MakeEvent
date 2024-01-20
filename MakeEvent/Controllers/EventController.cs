using MakeEvent.Context;
using MakeEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using System.Linq;

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

        [HttpPost]
        public IActionResult Create(Event _event)
        {
            _context.events.Add(_event);
            _context.SaveChanges();
            return View();
        }


        [HttpPost]
        public IActionResult Update(Event _event)
        {
            if (ModelState.IsValid)
            {
                _context.events.Update(_event);
                _context.SaveChangesAsync();
                // Уведомление об успешном изменении данных аккаунта
                return RedirectToAction("Account", "Account");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Event _event)
        {
            _context.events.Remove(_event);
            _context.SaveChanges();
            return View();
        }
        //_context.events.Include.ToList();
        private Event? FindElem(int? Id)
        {
            Event? ev = _context.events.Include(eve => eve.User).Include(eve => eve.Tags).FirstOrDefault(u => u.Id == Id);
            return ev;
        }
    }
}
