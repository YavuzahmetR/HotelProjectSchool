using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class _DashboardLast6Bookings : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardLast6Bookings(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/Booking/Last6Booking");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultLast6BookingDto>>(dataJs);
                return View(modelObject);
            }
            return View();
        }
    }
}
