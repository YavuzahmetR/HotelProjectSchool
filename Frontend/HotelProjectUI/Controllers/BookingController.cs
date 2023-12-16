using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
