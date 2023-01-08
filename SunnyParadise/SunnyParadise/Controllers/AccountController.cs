using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyParadise.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SunnyParadise.Controllers
{
    public class AccountController : Controller
    {
        private readonly SunnyParadiseDBContext _context;
        public AccountController(SunnyParadiseDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _context.Users.SingleOrDefaultAsync(q => q.Login == model.Login && q.Password == model.Password);
            if (user != null)
            {
                await Authenticate(model.Login, $"{user.FirstName} {user.LastName}");
                return RedirectToAction("Profile", "AccountProfile");
            }
            else
            {
                ModelState.AddModelError("", "User not found. Sign up, please");
                return View(model);
            }
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users.SingleOrDefaultAsync(q => q.Login == model.Login && q.Password == model.Password);
                if (user == null)
                {
                    await _context.Users.AddAsync(new User
                    {
                        Login = model.Login,
                        Password = model.Password,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Login,
                        Age = model.Age,
                        BirthDate = model.BirthDate,
                        Sex = model.Sex,
                        Phone = model.Phone,
                    });
                    await _context.SaveChangesAsync();
                    await Authenticate(model.Login,$"{model.FirstName} {model.LastName}");
                    return RedirectToAction("Home", "ResortsInfo");
                }
                else
                {
                    ModelState.AddModelError("", "User already registered. Log in please");
                }
            }
            return View(model);
        }
        private async Task Authenticate(string userLogin, string userFullName)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userLogin),
                    new Claim(ClaimTypes.UserData, userFullName)
                };
            var id = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(id);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Home", "ResortsInfo");
        }

    }
}
