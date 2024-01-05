using Hotel_Layer.Business.Abstract;
using Hotel_Layer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkPlaceController : ControllerBase
    {
        private readonly IWorkPlaceService _workPlaceService;
        public WorkPlaceController(IWorkPlaceService workPlaceService)
        {
            _workPlaceService = workPlaceService;
        }
        [HttpGet]
        public IActionResult WorkPlaceList()
        {
            var values = _workPlaceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddWorkPlace(WorkPlace workPlace)
        {
            _workPlaceService.TInsert(workPlace);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateWorkPlace(WorkPlace workPlace)
        {
            _workPlaceService.TUpdate(workPlace);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetWorkPlace(int id)
        {
            var value = _workPlaceService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteWorkPlace(int id)
        {
            var value = _workPlaceService.TGetById(id);
            _workPlaceService.TDelete(value);
            return Ok();
        }
    }
}
