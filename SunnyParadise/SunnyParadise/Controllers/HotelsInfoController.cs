using Microsoft.AspNetCore.Mvc;

namespace SunnyParadise.Controllers
{
    public class HotelsInfoController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult LaraBarut()
        {
            return View("Antaliya/LaraBarut");
        }
        public IActionResult ConcordeDeLuxe()
        {
            return View("Antaliya/ConcordeDeLuxe");
        }
        public IActionResult DelphinImperialHotel()
        {
            return View("Antaliya/DelphinImperialHotel");
        }

        public IActionResult Egypt()
        {
            return View("Sharm/Egypt");
        }
        public IActionResult Spain()
        {
            return View("Ibiza/Spain");
        }
        public IActionResult Hawaii()
        {
            return View("Hawaii/Hawaii");
        }
        public IActionResult Dubai()
        {
            return View("Dubai/Dubai");
        }
        public IActionResult Crete()
        {
            return View("Crete/Crete");
        }
    }
}
