using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.Controllers;
using EduHome.Helpers;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EduHome.Area.AdminEdu.Controllers
{
    //public class AdminAccountController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
        
    //        private readonly UserManager<AppUser> _userManager;
    //        private readonly SignInManager<AppUser> _signInManager;
    //        private readonly RoleManager<IdentityRole> _roleManager;
    //        public AdminAccountController(UserManager<AppUser> userManager,
    //            SignInManager<AppUser> signInManager,
    //            RoleManager<IdentityRole> roleManager)
    //        {
    //            _userManager = userManager;
    //            _signInManager = signInManager;
    //            _roleManager = roleManager;
    //        }
    //        public IActionResult Register()
    //        {
    //            return View();
    //        }
    //        [HttpPost]
    //        [ValidateAntiForgeryToken]
    //        public async Task<IActionResult> Signup(SignUpVM signup)
    //        {
    //            if (!ModelState.IsValid) return View(signup);
    //            AppUser newUser = new AppUser
    //            {
    //                UserName = signup.Username,
    //                PasswordHash = signup.Password
    //            };

    //            IdentityResult identityResult = await _userManager.CreateAsync(newUser, signup.Password);

    //            if (!identityResult.Succeeded)
    //            {
    //                foreach (var error in identityResult.Errors)
    //                {
    //                    ModelState.AddModelError("", error.Description);
    //                }
    //                return View(signup);
    //            }
    //            await _userManager.AddToRoleAsync(newUser, Helper.Roles.Member.ToString());
    //            await _signInManager.SignInAsync(newUser, true);
    //            return RedirectToAction("Index", "Home");
    //        }

    //        public async Task<IActionResult> Logout()
    //        {
    //            await _signInManager.SignOutAsync();
    //            return RedirectToAction(nameof(HomeController.Index), "Home");
    //        }

    //        public IActionResult Login()
    //        {
    //            return View();
    //        }

    //        [HttpPost]
    //        [ValidateAntiForgeryToken]
    //        public async Task<IActionResult> Login(LoginVM login)
    //        {
    //            if (!ModelState.IsValid) return View(login);
    //            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);
    //            if (loginUser == null)
    //            {
    //                ModelState.AddModelError("", "Qaqi mail sehvdir!!!");
    //                return View(login);
    //            }

    //            Microsoft.AspNetCore.Identity.SignInResult signInResult =
    //                await _signInManager.PasswordSignInAsync(loginUser, login.Password, false, true);

    //            if (!signInResult.Succeeded)
    //            {
    //                ModelState.AddModelError("", "Qaqi parol sehvdir!!!");
    //                return View(login);
    //            }
    //            string role = (await _userManager.GetRolesAsync(loginUser))[0];
    //            if (role == Helper.Roles.Admin.ToString())
    //            {
    //                return RedirectToAction("Index", "Dashboard", new { area = "AdminFiorello" });
    //            }
    //            else
    //            {
    //                return RedirectToAction("Index", "Home");
    //            }

    //        }

    //        public async Task CreateRole()
    //        {
    //            if (!await _roleManager.RoleExistsAsync(Helper.Roles.Admin.ToString()))
    //                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Admin.ToString()));

    //            if (!(await _roleManager.RoleExistsAsync(Helper.Roles.Member.ToString())))
    //                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Member.ToString()));
    //        }      
    //}
  
}
