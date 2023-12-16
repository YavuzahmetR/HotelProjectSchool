using HotelProjectUI.Dtos.Subscriber;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProjectUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory= httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _SubscriberPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _SubscriberPartial(CreateSubscriberDto createSubscriberDto)
        {
            var client = _httpClientFactory.CreateClient();
            var dataJs = JsonConvert.SerializeObject(createSubscriberDto);
            StringContent content = new StringContent(dataJs,Encoding.UTF8,"application/json");
            await client.PostAsync("https://localhost:7120/api/Subscriber", content);
            return RedirectToAction("Index","Default");
        }
    }
}
