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
        public IActionResult AidaHotel()
        {
            return View("Sharm/AidaHotel");
        }
        public IActionResult BoutiqueHotel()
        {
            return View("Sharm/BoutiqueHotel");
        }
        public IActionResult MagicWorld()
        {
            return View("Sharm/MagicWorld");
        }
        public IActionResult OKUIbiza()
        {
            return View("Ibiza/OKUIbiza");
        }
        public IActionResult RosellBoutique()
        {
            return View("Ibiza/RosellBoutique");
        }
        public IActionResult LuxIsla()
        {
            return View("Ibiza/LuxIsla");
        }
        public IActionResult KoloaLanding()
        {
            return View("Hawaii/KoloaLanding");
        }
        public IActionResult TrumpInternational()
        {
            return View("Hawaii/TrumpInternational");
        }
        public IActionResult Halepuna()
        {
            return View("Hawaii/Halepuna");
        }
        public IActionResult CaesarsPalace()
        {
            return View("Dubai/CaesarsPalace");
        }
        public IActionResult Mandarin()
        {
            return View("Dubai/Mandarin");
        }
        public IActionResult TajExotica()
        {
            return View("Dubai/TajExotica");
        }
        public IActionResult KavosHotel()
        {
            return View("Crete/KavosHotel");
        }
        public IActionResult CretaMaris()
        {
            return View("Crete/CretaMaris");
        }
        public IActionResult ChristinaBeach()
        {
            return View("Crete/ChristinaBeach");
        }
    }
}
