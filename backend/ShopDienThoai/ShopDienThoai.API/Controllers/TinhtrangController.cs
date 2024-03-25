using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Application.Services;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinhtrangController : ControllerBase
    {
        private readonly ITinhtrangService _tinhtrangService;
        public TinhtrangController(ITinhtrangService tinhtrangService)
        {
            _tinhtrangService = tinhtrangService;
        }
        [HttpGet]
        public IActionResult GetTinhtrang()
        {
            return Ok(_tinhtrangService.GetTinhtrangs());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetTinhtrangById(int id)
        {
            var tinhtrang = _tinhtrangService.GetTinhtrangById(id);
            if (tinhtrang == null)
            {
                return NotFound();
            }
            return Ok(tinhtrang);
        }
        [HttpPost]
        public IActionResult PostTinhtrang(TinhtrangDTO tinhtrangDTO)
        {
            if (!_tinhtrangService.AddTinhtrang(tinhtrangDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTinhtrang(int id)
        {
            if (!_tinhtrangService.DeleteTinhtrang(id))
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateTinhtrang(TinhtrangDTO tinhtrangDTO)
        {
            if (!_tinhtrangService.UpdateTinhtrang(tinhtrangDTO))
            {
                return BadRequest();
            }
            return Ok(tinhtrangDTO);
        }
    }
}
