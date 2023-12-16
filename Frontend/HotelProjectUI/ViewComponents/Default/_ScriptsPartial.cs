using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class _ScriptsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
