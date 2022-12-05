using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyParadise;
using SunnyParadise.Models;
using System.Diagnostics;

namespace MyWebProject.Controllers
{
    public class ResortsInfoController : Controller
    {
        private readonly ILogger<ResortsInfoController> _logger;
        private readonly SunnyParadiseDBContext _context;

        public ResortsInfoController(ILogger<ResortsInfoController> logger, SunnyParadiseDBContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Turkey()
        {
            return View();
        }
        public IActionResult Egypt()
        {
            return View();
        }
        public IActionResult Spain()
        {
            return View();
        }
        public IActionResult Hawaii()
        {
            return View();
        }
        public IActionResult Dubai()
        {
            return View();
        }
        public IActionResult Crete()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}