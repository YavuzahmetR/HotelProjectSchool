using HotelProjectUI.Dtos.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectUI.ViewComponents.Default
{
    public class _AboutPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;   
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/About");
            if(response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultAboutDto>>(dataJs);
                return View(modelObject);
            }
            return View();
        }
    }
}
