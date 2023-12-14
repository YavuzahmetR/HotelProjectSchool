using Hotel_Layer.Business.Abstract;
using Hotel_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IService_Service _service;
        public ServiceController(IService_Service service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _service.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _service.TInsert(service);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service service) 
        {
            _service.TUpdate(service);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var value = _service.TGetById(id);
            _service.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetServices(int id)
        {
            var value = _service.TGetById(id);
            return Ok(value);
        }

    }
}
