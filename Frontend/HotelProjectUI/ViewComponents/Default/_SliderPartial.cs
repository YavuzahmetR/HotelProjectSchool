﻿using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
