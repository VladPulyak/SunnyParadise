using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SunnyParadise.Controllers
{
    [Authorize]
    public class AccountProfileController : Controller
    {
        public IActionResult Test()
        {
            return View();
        }
    }
}
