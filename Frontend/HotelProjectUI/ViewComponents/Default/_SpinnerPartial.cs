using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class _SpinnerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
