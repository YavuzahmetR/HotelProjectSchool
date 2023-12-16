using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent
    {
        //default method adı invokedir. Partial Yapısına sahip ancak direkt url erişimi bulunmuyor.(EF Core)
        //Çeşitlilik için yazıldı.
        //Shared dosyası altında view'lar tanımlanmalı. Views/Shared/Components/_HeadPartial/Default.cshtml
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
