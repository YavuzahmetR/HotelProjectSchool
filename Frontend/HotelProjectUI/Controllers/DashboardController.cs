using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
