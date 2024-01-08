using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class _DashboardScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
