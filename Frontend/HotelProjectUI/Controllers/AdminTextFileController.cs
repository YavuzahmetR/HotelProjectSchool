using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace HotelProjectUI.Controllers
{
    public class AdminTextFileController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(IFormFile textFile)
        {
            var stream = new MemoryStream();
            await textFile.CopyToAsync(stream);
            var bytes = stream.ToArray();

            ByteArrayContent byteArray = new ByteArrayContent(bytes);
            byteArray.Headers.ContentType = new MediaTypeHeaderValue(textFile.ContentType);
            MultipartFormDataContent multipartFormData = new MultipartFormDataContent();
            multipartFormData.Add(byteArray, "file", textFile.FileName);
            var httpClient = new HttpClient();
            await httpClient.PostAsync("https://localhost:7120/api/TextFile", multipartFormData);
            return View();
        }
    }
}
