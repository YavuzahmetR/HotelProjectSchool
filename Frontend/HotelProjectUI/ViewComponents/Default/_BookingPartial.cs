using Microsoft.AspNetCore.Mvc;
namespace HotelProjectUI.ViewComponents.Default
{
    public class _BookingPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
