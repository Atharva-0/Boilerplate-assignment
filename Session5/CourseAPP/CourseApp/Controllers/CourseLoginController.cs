using CourseApp.Constants;
using CourseApp.Context;
using CourseApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseLoginController : Controller
    {
        readonly UserManager<IdentityUser> _manager;
        readonly SignInManager<IdentityUser> _signInManager;
        readonly ApplicationDbContext _context;
        public CourseLoginController(UserManager<IdentityUser> manager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _manager = manager;
            _signInManager = signInManager;
            _context = context;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        // [AllowAnonymous]
        public async Task<IActionResult> Register(Register user)
        {
            if (ModelState.IsValid)
            {
                var createdUser = new IdentityUser { UserName = user.Email, Email = user.Email };
                var result = await _manager.CreateAsync(createdUser, user.Password);
                _context.Emails.Add(new Emailtbl { Email = user.Email });
                   
                if (result.Succeeded)
                {
                    await _manager.AddToRoleAsync(createdUser, Roles.User);
                    return RedirectToAction("LogIn");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
            return View(user);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(Login loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
                var user=await _manager.FindByEmailAsync(loginModel.Email);
                if (result.Succeeded)
                {
                    if (loginModel.Email == "admin@gmail.com")
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                    /*    HttpContext.Session.SetString("Email", user.Email);*/
                        return RedirectToAction("Index", "User");
                    }
                }
                ModelState.AddModelError("", "Login Failed");
            }
            return View(loginModel);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LogIn");
        }

    }
}
