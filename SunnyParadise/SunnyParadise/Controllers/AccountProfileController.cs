using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Dtos;

namespace SunnyParadise.Controllers
{
    [Authorize]
    public class AccountProfileController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }
		public IActionResult ChangeProfile()
		{
			return View();
		}
		[HttpPut]
		public IActionResult ChangeProfile(UserDto user)
		{
			return View();
		}
	}
}
