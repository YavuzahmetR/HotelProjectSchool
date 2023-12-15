using Hotel_Layer.Entities.Concrete;
using HotelProjectUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    public class SignInController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        public SignInController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SignInUserDto signInUser)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(signInUser.UserName, signInUser.Password, false, false);
                if(signInResult.Succeeded)
                {
                    return RedirectToAction("Index","Staff");
                }
            }
            return View();
        }
    }
}
