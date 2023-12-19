using HotelProjectUI.Dtos.RoomDto;
using HotelProjectUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class RoomAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RoomAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/Room");
            if (response.IsSuccessStatusCode)//200-299
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultRoomDto>>(dataJs);
                return View(modelObject);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(CreateRoomDto viewModel)
        {
            //checbox wifi durumu için (default olarak var ekleniyordu böyle değiştirdim)
            string wifiStatus = viewModel.Wifi;
            if (!string.IsNullOrEmpty(wifiStatus))
            {
                viewModel.Wifi = "Var";
            }
            else
            {
                viewModel.Wifi = "Yok";
            }
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(viewModel);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7120/api/Room", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7120/api/Room/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7120/api/Room/{id}");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<UpdateRoomDto>(dataJs);
                return View(modelObject);

            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDto updateModel)
        {
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(updateModel);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"https://localhost:7120/api/Room", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
