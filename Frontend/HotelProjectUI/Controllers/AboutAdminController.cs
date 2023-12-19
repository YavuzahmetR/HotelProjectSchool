using HotelProjectUI.Dtos.AboutDto;
using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class AboutAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AboutAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/About");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultAboutDto>>(dataJs);
                return View(modelObject);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7120/api/About/{id}");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<UpdateAboutDto>(dataJs);
                return View(modelObject);

            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto dtoModel)
        {
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(dtoModel);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"https://localhost:7120/api/About", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
