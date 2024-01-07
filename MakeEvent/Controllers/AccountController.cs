using MakeEvent.Context;
using MakeEvent.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeEvent.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly AppDbContext _context;

        public AccountController(ILogger<AccountController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? Id)
        {
            User? user = _context.users.Find(Id);
            return View(user);
        }
        public IActionResult Account(int? id)
        {
            return View(FindUser(1));
        }

        private User? FindUser(int? Id)
        {
            return _context.users.Find(Id);
        }

        [HttpPost]
        public IActionResult Edit(User _user)
        {
            if(ModelState.IsValid)
            {
                _context.users.Update(_user);
                _context.SaveChangesAsync();
                return RedirectToAction("Account");
            }
            return View();
        }
    }
}
