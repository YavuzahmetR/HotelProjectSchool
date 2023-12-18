using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Contact
{
    public class _ContactCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
