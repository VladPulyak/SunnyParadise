using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Dtos;
using BusinessLayer.Interfaces;

namespace SunnyParadise.Controllers
{
    [Authorize]
    public class AccountProfileController : Controller
    {
		private readonly IUserService _userService;
		public AccountProfileController(IUserService userService)
		{
			_userService = userService;
		}
        public IActionResult Test()
        {
			var userEmail = HttpContext.User.Identity.Name;
            var user = _userService.GetUsers().Result.Find(x => x.Email == userEmail);
            return View(user);
        }
		public IActionResult ChangeProfile()
		{
            var userEmail = HttpContext.User.Identity.Name;
            var user = _userService.GetUsers().Result.Find(x => x.Email == userEmail);
            return View(user);
        }

        [HttpPost]
		public async Task<IActionResult> ChangeProfile(UserDto newUser)
		{
            var userEmail = HttpContext.User.Identity.Name;
            var user = _userService.GetUsers().Result.Find(x => x.Email == userEmail);
            await _userService.UpdateUser(user.Id, newUser);
			return RedirectToAction("Test","AccountProfile");
		}
	}
}
