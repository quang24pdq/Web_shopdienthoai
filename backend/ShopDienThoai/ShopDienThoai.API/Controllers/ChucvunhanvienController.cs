using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;

namespace ShopDienThoai.API.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    public class ChucvunhanvienController : ControllerBase
    {
        private readonly IChucvunhanvienService _chucvunhanvienService;
        public ChucvunhanvienController(IChucvunhanvienService chucvunhanvienService)
        {
            _chucvunhanvienService = chucvunhanvienService;
        }
        [HttpGet]
        public IActionResult GetAllChucvunhanvien()
        {
            return Ok(_chucvunhanvienService.GetChucvunhanvienList());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetChucvunhanvienById(int id)
        {
            var chucvunhanvien = _chucvunhanvienService.GetChucvunhanvienById(id);
            if(chucvunhanvien == null)
            {
                return NotFound();
            }
            return Ok(chucvunhanvien);
        }
        [HttpPost]
        /*[Authorize]*/
        public IActionResult ThemChucvunhanvien(ChucvunhanvienDTO chucvunhanvienDTO)
        {
            if(!_chucvunhanvienService.AddChucvunhanvien(chucvunhanvienDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteChucvunhanvien(int id)
        {
            var obj = _chucvunhanvienService.DeleteChucvunhanvien(id);
            if(obj)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult UpdateChucvunhanvien(ChucvunhanvienDTO chucvunhanvienDTO)
        {
            if(!_chucvunhanvienService.UpdateChucvunhanvien(chucvunhanvienDTO))
            {
                return BadRequest();
            }
            return Ok(chucvunhanvienDTO);
        }

    }
}
