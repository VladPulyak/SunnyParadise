using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Dtos;
using BusinessLayer.Interfaces;
using AutoMapper;
using SunnyParadise.Models;
using DataLayer;

namespace SunnyParadise.Controllers
{
    [Authorize]
    public class AccountProfileController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        private readonly IResortService _resortService;
        private readonly IHotelService _hotelService;
        private readonly IMapper _mapper;
        public AccountProfileController(IUserService userService, IOrderService orderService, IResortService resortService, IHotelService hotelService, IMapper mapper)
        {
            _userService = userService;
            _orderService = orderService;
            _resortService = resortService;
            _hotelService = hotelService;
            _mapper = mapper;
        }
        public IActionResult Profile()
        {
            var userEmail = HttpContext.User.Identity.Name;
            var user = _userService.GetUsers().Result.Find(x => x.Email == userEmail);
            var userViewModel = _mapper.Map<UserViewModel>(user);
            return View(userViewModel);
        }
        [HttpGet]
        public IActionResult ChangeProfile()
        {
            var userEmail = HttpContext.User.Identity.Name;
            var user = _userService.GetUsers().Result.Find(x => x.Email == userEmail);
            var userViewModel = _mapper.Map<UserViewModel>(user);
            return View(userViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeProfile(UserViewModel newUser)
        {
            var userEmail = HttpContext.User.Identity.Name;
            var user = _userService.GetUsers().Result.Find(x => x.Email == userEmail);
            var newUserDto = _mapper.Map<UserDto>(newUser);
            newUserDto.Id = user.Id;
            await _userService.UpdateUser(user.Id, newUserDto);
            return RedirectToAction("Profile", "AccountProfile");
        }

        [HttpGet]
        public async Task<IActionResult> MakeOrder()
        {
            var hotels = await _hotelService.GetHotels();
            var resorts = await _resortService.GetResorts();
            ViewData["Hotels"] = hotels;
            ViewData["Resorts"] = resorts;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MakeOrder(OrderViewModel orderViewModel)
        {
            var userEmail = HttpContext.User.Identity.Name;
            var userId = _userService.GetUsers().Result.Where(q => q.Email == userEmail).SingleOrDefault().Id;
            var resort = _resortService.GetResorts().Result.Where(q => (q.City == orderViewModel.City) && (q.Country == orderViewModel.Country)).SingleOrDefault();
            var hotel = _hotelService.GetHotels().Result.Where(q => q.Name == orderViewModel.HotelName).SingleOrDefault();
            orderViewModel.UserEmail = userEmail;
            orderViewModel.DateOfCreating = DateTime.Now;
            var orderDto = _mapper.Map<OrderDto>(orderViewModel);
            orderDto.UserId = userId;
            orderDto.HotelId = hotel.Id;
            orderDto.ResortId = resort.Id;
            await _orderService.AddOrder(orderDto);
            return RedirectToAction("GetOrders", "AccountProfile");
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _orderService.GetOrders();
            var listWithOrderViewModels = new List<OrderViewModel>();
            var userEmail = HttpContext.User.Identity.Name;
            var userId = _userService.GetUsers().Result.Where(q => q.Email == userEmail).SingleOrDefault().Id;
            foreach (var orderDto in orders)
            {
                if (orderDto.UserId == userId)
                {
                    listWithOrderViewModels.Add(new OrderViewModel
                    {
                        OrderId= orderDto.OrderId,
                        UserEmail = HttpContext.User.Identity.Name,
                        CountOfDays = orderDto.CountOfDays,
                        DateOfCreating = orderDto.DateOfCreating,
                        DateOfTrip = orderDto.DateOfTrip,
                        HotelName = _hotelService.GetHotel(orderDto.HotelId).Result.Name,
                        Country = _resortService.GetResort(orderDto.ResortId).Result.Country,
                        City = _resortService.GetResort(orderDto.ResortId).Result.City
                    });
                }
            }
            return View(listWithOrderViewModels);
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
        [HttpGet]
        public IActionResult AddResort()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddResort(ResortDto resort)
        {
            await _resortService.AddResort(resort);
            return View();
        }
        public async Task<IActionResult> CancelOrder(int orderId)
        {
            await _orderService.DeteleOrder(orderId);
            return RedirectToAction("GetOrders", "AccountProfile");
        }
    }
}
