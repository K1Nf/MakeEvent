using MakeEvent.Context;
using MakeEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.Intrinsics.X86;

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


        [HttpPost]
        public IActionResult Edit(User _user)
        {
            foreach (char c in _user.PhoneNumber)
            {
                if (!char.IsDigit(c))
                    ModelState.AddModelError("PhoneNumber", "Введите настоящий номер телефона"); 
            }
           
        
            if(ModelState.IsValid)
            {
                _context.users.Update(_user);
                _context.SaveChangesAsync();
                // Уведомление об успешном изменении данных аккаунта
                return RedirectToAction("Account");
            }
            return View(_user);
        }

        private User? FindUser(int? Id)
        {
            return _context.users.Find(Id);
        }
    }
}
