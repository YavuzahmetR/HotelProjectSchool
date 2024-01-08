using HotelProjectUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/DashboardWidgets/StaffCount");
            var dataJs = await response.Content.ReadAsStringAsync();
            ViewBag.staffCount = dataJs;

            var client2 = _httpClientFactory.CreateClient();
            var response2 = await client2.GetAsync("https://localhost:7120/api/DashboardWidgets/BookingCount");
            var dataJs2 = await response2.Content.ReadAsStringAsync();
            ViewBag.bookingCount = dataJs2;

            var client3 = _httpClientFactory.CreateClient();
            var response3 = await client3.GetAsync("https://localhost:7120/api/DashboardWidgets/AppUserCount");
            var dataJs3 = await response3.Content.ReadAsStringAsync();
            ViewBag.appUserCount = dataJs3;

            var client4 = _httpClientFactory.CreateClient();
            var response4 = await client4.GetAsync("https://localhost:7120/api/DashboardWidgets/RoomCount");
            var dataJs4 = await response4.Content.ReadAsStringAsync();
            ViewBag.roomCount = dataJs4;

            return View();
        }
    }
}
