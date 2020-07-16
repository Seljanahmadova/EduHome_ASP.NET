using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class AllUserController : Controller
    {
        private readonly UserManager<User> _userManager;
        public AllUserController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<User> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();
            foreach (User user in users)
            {
                UserVM userVM = new UserVM
                {
                    Username = user.Username,
                    Email = user.Email,
                    Role = await _userManager.GetRolesAsync(user)
                };

                usersVM.Add(userVM);
            }

            return Json(usersVM);
        }
    }
}
