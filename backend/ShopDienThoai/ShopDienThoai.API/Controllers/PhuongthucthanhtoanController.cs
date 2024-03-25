using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Application.Services;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhuongthucthanhtoanController : ControllerBase
    {
        private readonly IPhuongthucthanhtoanService _phuongthucthanhtoanService;
        public PhuongthucthanhtoanController(IPhuongthucthanhtoanService phuongthucthanhtoanService)
        {
            _phuongthucthanhtoanService = phuongthucthanhtoanService;
        }
        [HttpGet]
        public IActionResult GetAllPhuongthucthanhtoan()
        {
            return Ok(_phuongthucthanhtoanService.GetAllPhuongthucthanhtoan());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetPhuongthucthanhtoanById(int id)
        {
            var phuongthucthanhtoan = _phuongthucthanhtoanService.GetPhuongthucthanhtoanById(id);
            if (phuongthucthanhtoan == null)
            {
                return NotFound();
            }
            return Ok(phuongthucthanhtoan);
        }
        [HttpPost]
        public IActionResult PostPhuongthucthanhtoan(PhuongthucthanhtoanDTO phuongthucthanhtoanDTO)
        {
            if (!_phuongthucthanhtoanService.AddPhuongthucthanhtoan(phuongthucthanhtoanDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePhuongthucthanhtoan(int id)
        {
            if (!_phuongthucthanhtoanService.DeletePhuongthucthanhtoan(id))
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdatePhuongthucthanhtoan(PhuongthucthanhtoanDTO phuongthucthanhtoanDTO)
        {
            if (!_phuongthucthanhtoanService.UpdatePhuongthucthanhtoan(phuongthucthanhtoanDTO))
            {
                return BadRequest();
            }
            return Ok(phuongthucthanhtoanDTO);
        }

    }
}
