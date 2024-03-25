using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Application.Services;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChitiethoadonController : ControllerBase
    {
        private readonly IChitiethoadonService _chitiethoadonService;
        public ChitiethoadonController(IChitiethoadonService chitiethoadonService)
        {
            _chitiethoadonService = chitiethoadonService;
        }
        [HttpGet]
        public IActionResult GetAllChitiethoadon()
        {
            return Ok(_chitiethoadonService.GetAllChitiethoadon());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetChitiethoadonById(int id)
        {
            var chitiethoadon = _chitiethoadonService.GetChitiethoadonById(id);
            if (chitiethoadon == null)
            {
                return NotFound();
            }
            return Ok(chitiethoadon);
        }
        [HttpPost]
        public IActionResult ThemChitiethoadon(ChitiethoadonDTO chitiethoadonDTO)
        {
            if (!_chitiethoadonService.AddChitiethoadon(chitiethoadonDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteChitiethoadon(int id)
        {
            var obj = _chitiethoadonService.DeleteChitiethoadon(id);
            if (obj)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult UpdateChitiethoadon(ChitiethoadonDTO chitiethoadonDTO)
        {
            if (!_chitiethoadonService.UpdateChitiethoadon(chitiethoadonDTO))
            {
                return BadRequest();
            }
            return Ok(chitiethoadonDTO);
        }
    }
}
