using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Application.Services;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinhluanController : ControllerBase
    {
        private readonly IBinhluanService _binhluanService;
        public BinhluanController(IBinhluanService binhluanService)
        {
            _binhluanService = binhluanService;
        }
        [HttpGet]
        public IActionResult GetAllBinhluan()
        {
            return Ok(_binhluanService.GetAllBinhluan());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetBinhluanById(int id)
        {
            var binhluan = _binhluanService.GetBinhluanById(id);
            if (binhluan == null)
            {
                return NotFound();
            }
            return Ok(binhluan);
        }
        [HttpPost]
        public IActionResult ThemBinhluan(BinhluanDTO binhluanDTO)
        {
            if (!_binhluanService.AddBinhluan(binhluanDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBinhluan(int id)
        {
            var obj = _binhluanService.DeleteBinhluan(id);
            if (obj)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult UpdateBinhluan(BinhluanDTO binhluanDTO)
        {
            if (!_binhluanService.UpdateBinhluan(binhluanDTO))
            {
                return BadRequest();
            }
            return Ok(binhluanDTO);
        }
    }
}
