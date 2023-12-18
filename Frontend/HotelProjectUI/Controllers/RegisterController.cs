using Hotel_Layer.Entities.Concrete;
using HotelProjectUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateUserDto createUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser
            {
                Name = createUserDto.Name,
                Email = createUserDto.Email,
                Surname = createUserDto.Surname,
                UserName = createUserDto.UserName,
                City = createUserDto.City = ""
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
