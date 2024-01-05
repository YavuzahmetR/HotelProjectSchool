using HotelProjectUI.Dtos.RoomDto;
using HotelProjectUI.Dtos.WorkPlaceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class AdminWorkPlaceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminWorkPlaceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/WorkPlace");
            if (response.IsSuccessStatusCode)//200-299
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<List<ResultWorkPlaceDto>>(dataJs);
                return View(modelObject);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddWorkPlace()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddWorkPlace(CreateWorkPlaceDto viewModel)
        {
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(viewModel);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7120/api/WorkPlace", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteWorkPlace(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.DeleteAsync($"https://localhost:7120/api/WorkPlace/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateWorkPlace(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7120/api/WorkPlace/{id}");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<UpdateWorkPlaceDto>(dataJs);
                return View(modelObject);

            }
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> UpdateWorkPlace(UpdateWorkPlaceDto updateModel)
        {
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(updateModel);
            StringContent content = new StringContent(dataJs, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"https://localhost:7120/api/WorkPlace", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
