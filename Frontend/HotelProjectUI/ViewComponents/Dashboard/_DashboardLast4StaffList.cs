using HotelProjectUI.Dtos.GuestDto;
using HotelProjectUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class _DashboardLast4StaffList : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DashboardLast4StaffList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/Staff/Last4Staff");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultLast4StaffDto>>(dataJs);
                return View(modelObject);
            }
            return View();
        }
    }
}
