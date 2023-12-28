using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextFileController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> TextUpload([FromForm] IFormFile file)
        {
            try
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    var directory = Path.Combine(Directory.GetCurrentDirectory(), "files", fileName);

                    using (var fileStream = new FileStream(directory, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    var fileContent = await System.IO.File.ReadAllTextAsync(directory);
                    return Ok(new { fileName, fileContent });
                }
                else
                {
                    return BadRequest("Dosya bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Sunucu Hatası: {ex}");
            }
        }
    }
}
