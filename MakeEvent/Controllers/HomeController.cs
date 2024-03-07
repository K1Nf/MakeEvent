using MakeEvent.Context;
using MakeEvent.Migrations;
using MakeEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MakeEvent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;
        private readonly TimeService _ts;
        //private readonly HttpContext _httpcontext;
        public HomeController(ILogger<HomeController> logger, AppDbContext context, TimeService timeService /*HttpContext httpcontext*/)
        {
            _ts = timeService;
            _logger = logger;
            _context = context;
            
            //_httpcontext = httpcontext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Event> events = _context.events.Include(e => e.User).Where(e => e.Date >= DateOnly.FromDateTime(DateTime.Now.Date)).ToList();
            ViewData["tss"] = _ts.GetTime();
            //ViewData["_httpcontext"] = _httpcontext.Request.Cookies;
            return View(events);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
