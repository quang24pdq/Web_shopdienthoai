using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Application.Services;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoadonController : ControllerBase
    {
        private readonly IHoadonService _hoadonService;
        public HoadonController(IHoadonService hoadonService)
        {
            _hoadonService = hoadonService;
        }
        [HttpGet]
        public IActionResult GetAllHoadon()
        {
            return Ok(_hoadonService.GetAllHoadon());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetHoadonById(int id)
        {
            var hoadon = _hoadonService.GetHoadonById(id);
            if (hoadon == null)
            {
                return NotFound();
            }
            return Ok(hoadon);
        }
        [HttpPost]
        public IActionResult ThemHoadon(HoadonDTO hoadonDTO)
        {
            if (!_hoadonService.AddHoadon(hoadonDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHoadon(int id)
        {
            var obj = _hoadonService.DeleteHoadon(id);
            if (obj)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult UpdateHoadon(HoadonDTO hoadonDTO)
        {
            if (!_hoadonService.UpdateHoadon(hoadonDTO))
            {
                return BadRequest();
            }
            return Ok(hoadonDTO);
        }
    }
}
