using HotelProjectUI.Dtos.AboutDto;
using HotelProjectUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectUI.ViewComponents.Default
{
    public class _ServicePartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _ServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/Service");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultServiceDto>>(dataJs);
                return View(modelObject);
            }
            return View();
        }
    }
}
