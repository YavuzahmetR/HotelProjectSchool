using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class _DashboardHeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
