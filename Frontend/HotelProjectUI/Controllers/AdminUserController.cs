using Hotel_Layer.Entities.Concrete;
using HotelProjectUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectUI.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminUserController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/AppUser");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultAppUserDto>>(dataJs);
                return View(modelObject);
            }
            return View();
        }
    }
}
