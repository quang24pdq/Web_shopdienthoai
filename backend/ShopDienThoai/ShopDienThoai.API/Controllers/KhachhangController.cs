using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Domain.Repositories;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachhangController : ControllerBase
    {
        private readonly IKhachhangService _khachhangService;
        public KhachhangController(IKhachhangService khachhangService)
        {
            _khachhangService = khachhangService;
        }
        [HttpGet]
        public IActionResult GetAllKhachhang()
        {
            return Ok(_khachhangService.GetAllKhachhang());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetKhachhangById(int id)
        {
            var khachhang = _khachhangService.GetKhachhangById(id);
            if(khachhang == null)
            {
                return NotFound();
            }
            return Ok(khachhang);
        }
        [HttpPost]
        public IActionResult ThemKhachhang(KhachhangDTO khachhangDTO)
        {
            if(!_khachhangService.AddKhachhang(khachhangDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteKhachhang(int id)
        {
            if(_khachhangService.DeleteKhachhang(id))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateKhachhang(KhachhangDTO khachhangDTO)
        {
            if(!_khachhangService.UpdateKhachhang(khachhangDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
