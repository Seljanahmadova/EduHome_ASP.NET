using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class EventController : Controller
    {
        public readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Event> event1 = _db.Event.ToList();
            return View(event1);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
