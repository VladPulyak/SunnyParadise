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
        private readonly IOrderService _orderService;
        private readonly IResortService _resortService;
        private readonly IHotelService _hotelService;
        public AccountProfileController(IUserService userService, IOrderService orderService, IResortService resortService,IHotelService hotelService)
        {
            _userService = userService;
            _orderService = orderService;
            _resortService = resortService;
            _hotelService = hotelService;
        }
        public IActionResult Profile()
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
            return RedirectToAction("Profile", "AccountProfile");
        }

        [HttpGet]
        public async Task<IActionResult> MakeOrder()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MakeOrder(OrderDto order, string resortName, string hotelName)
        {
            var userEmail = HttpContext.User.Identity.Name;
            order.UserId = _userService.GetUsers().Result.Where(q => q.Email == userEmail).Single().Id;
            await _orderService.AddOrder(order);
            return View();
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddHotel()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddHotel(HotelDto hotel)
        {
            await _hotelService.AddHotel(hotel);
            return View();
        }
    }
}
