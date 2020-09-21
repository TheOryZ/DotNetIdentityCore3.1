using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Entities.Concrete;
using Example.MVCWebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Example.MVCWebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindByEmailAsync(model.Email).Result;

                if (user != null)
                {
                    var result = _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).Result;
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid Credentials.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User Not Found.");
                }
            }
            return View(model);
        }

        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser { Email = model.Email, UserName = model.Email, Name = model.Firstname, Surname = model.Lastname };
                var result = _userManager.CreateAsync(user, model.Password).Result;

                if (result.Succeeded)
                {
                    var signInResult = _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false).Result;
                    if (signInResult.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            var result = _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}