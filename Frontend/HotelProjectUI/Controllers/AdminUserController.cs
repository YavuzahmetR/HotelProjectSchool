using Hotel_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AdminUserController(UserManager<AppUser> _userManager)
        {
            this._userManager = _userManager;
        }
        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
