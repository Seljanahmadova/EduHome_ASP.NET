using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EduHome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> teacher = _db.Teacher.ToList();
            return View(teacher);

        }

        public async Task<IActionResult> Detail(int id)
        {
            
            Teacher teacher =await _db.Teacher.Include(t => t.Skill).FirstOrDefaultAsync(t => t.Id == id);
            if (teacher == null) return NotFound();
            return View(teacher);
        }

        public IActionResult Search(string search) 
        {
            var model = _db.Teacher.Where(m => m.Fullname.Contains(search)).OrderByDescending(m => m.Experience).Take(10).ToList();
            return View( model);
        }
    }
}
