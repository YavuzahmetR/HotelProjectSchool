using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    public class ErrorStatusPageController : Controller
    {
        public IActionResult E404()
        {
            return View();
        }
    }
}
