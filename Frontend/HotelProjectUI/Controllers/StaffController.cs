using HotelProjectUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class StaffController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StaffController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            //Client yaratıyorum. İstek oluşturabilmek için
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7120/api/Staff");
            if (response.IsSuccessStatusCode)//200-299
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                //Swagger json formatında veri döndürüyor. Kendi tabloma döndürmek için .Net formatına dönüştürüyorum
                var modelObject = JsonConvert.DeserializeObject<List<StaffViewModel>>(dataJs); 
                return View(modelObject);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel viewModel)
        {
            var client = _httpClientFactory.CreateClient();
            //Post edilecek veri json formatına dönüştürülmeli.Serialize Onject method.
            var dataJs = JsonConvert.SerializeObject(viewModel);
            //dataJs formatının içeriğini , metnin utf-8'e olduğunu, ve içerik türünün Json formatında olduğunu content nesnesine bildiriyoruz.
            StringContent content = new StringContent(dataJs,Encoding.UTF8,"application/json");
            var response = await client.PostAsync("https://localhost:7120/api/Staff", content);
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteStaff(int id)
        {
            var client = _httpClientFactory.CreateClient();
            //id parametresi özellikle path'te geçilmeli.
            var response = await client.DeleteAsync($"https://localhost:7120/api/Staff/{id}");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateStaff(int id)
        {
            var client =  _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7120/api/Staff/{id}");
            if (response.IsSuccessStatusCode)
            {
                var dataJs = await response.Content.ReadAsStringAsync();
                var modelObject = JsonConvert.DeserializeObject<UpdateStaffViewModel>(dataJs);
                return View(modelObject);

            }
            return View();

        }
        
        [HttpPost]
        public async Task<IActionResult> UpdateStaff(UpdateStaffViewModel updateModel)
        {
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(updateModel);
            StringContent content = new StringContent(dataJs,Encoding.UTF8,"application/json");
            var response = await client.PutAsync($"https://localhost:7120/api/Staff",content);
            if(response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
