using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiSanPhamController : ControllerBase
    {
        private readonly ILoaisanphamService _loaisanphamService;
        public LoaiSanPhamController(ILoaisanphamService loaisanphamService)
        {
            _loaisanphamService = loaisanphamService;
        }
        [HttpGet]
        public IActionResult GetAllLoaiSanPham()
        {
            return Ok(_loaisanphamService.GetLoaisanphams());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetLoaiSanPhamById(int id)
        {
            var loaisanpham = _loaisanphamService.GetLoaisanphamById(id);
            if(loaisanpham == null)
            {
                return NotFound();
            }
            return Ok(loaisanpham);
        }
        [HttpPost]
        public IActionResult PostLoaiSanPham(LoaisanphamDTO loaisanphamDTO)
        {
            if(!_loaisanphamService.AddLoaiSanPham(loaisanphamDTO))
            {
                return BadRequest();
            }
            /*return CreatedAtAction("NewLoaiSanPham", new { id = loaisanphamDTO.Id }, loaisanphamDTO);*/
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteLoaiSanPham(int id)
        {
            if(_loaisanphamService.DeleteLoaiSanPham(id))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateLoaiSanPham(LoaisanphamDTO loaisanphamDTO)
        {
            if(!_loaisanphamService.UpdateLoaiSanPham(loaisanphamDTO))
            {
                return BadRequest();
            }
            return Ok(loaisanphamDTO);
        }
    }
}
