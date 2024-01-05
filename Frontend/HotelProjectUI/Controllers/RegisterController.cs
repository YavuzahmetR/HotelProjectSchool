using Hotel_Layer.DataAccess.Concrete;
using Hotel_Layer.Entities.Concrete;
using HotelProjectUI.Dtos.AppUserDto;
using HotelProjectUI.Dtos.CityDto;
using HotelProjectUI.Dtos.MessageCategoryDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly Context _context;
        private readonly IHttpClientFactory _httpClientFactory;
        public RegisterController(UserManager<AppUser> userManager, IHttpClientFactory httpClientFactory, Context context)
        {
            _userManager = userManager;
            _httpClientFactory = httpClientFactory;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/City");
            var dataJs = await response.Content.ReadAsStringAsync();
            var modelObject = JsonConvert.DeserializeObject<List<ResultCityDto>>(dataJs);
            List<SelectListItem> citiesOfTurkey = (from item in modelObject
                                                   select new SelectListItem
                                                   {
                                                       Text = item.CityName,
                                                       Value = item.CityName
                                                   }).ToList();
            ViewBag.City = citiesOfTurkey;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateUserDto createUserDto)
        {
            Random rand = new Random();
            if(!ModelState.IsValid)
            {
                return View();
            }
            int workPlaceId = rand.Next(1,6);
            var workPlace = _context.WorkPlaces.FirstOrDefault(wp => wp.WorkPlaceID == workPlaceId);
            var appUser = new AppUser
            {
                Name = createUserDto.Name,
                Email = createUserDto.Email,
                Surname = createUserDto.Surname,
                UserName = createUserDto.UserName,
                City = createUserDto.City,
                WorkPlaceID = workPlaceId,
                WorkDepartment = workPlace?.WorkPlaceName,
                ImageUrl = "/adminweb/images/avatar/4.jpg"
            };
            var userPasswordResult = await _userManager.CreateAsync(appUser,createUserDto.Password);
            if(userPasswordResult.Succeeded)
            {
                return RedirectToAction("Index","SignIn");
            }
            
            return View();
        }
    }
}
