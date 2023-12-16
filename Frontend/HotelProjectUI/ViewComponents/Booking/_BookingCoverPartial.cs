using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Booking
{
    public class _BookingCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
