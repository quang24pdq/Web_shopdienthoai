using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Infrastructure.Context;
using System.Text.RegularExpressions;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly ISanPhamService _sanphamService;
        private readonly KinhdoanhdienthoaiContext context;
        public SanPhamController(ISanPhamService sanphamService, KinhdoanhdienthoaiContext context)
        {
            _sanphamService = sanphamService;
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetSanPhams() {
            return Ok(_sanphamService.GetSanphams());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetSanPhamById(int id)
        {
            var sanpham = _sanphamService.GetSanPhamById(id);
            if(sanpham == null)
            {
                return NotFound();
            }
            return Ok(sanpham);
        }
       
        [HttpPost]
        public IActionResult PostSanPham(SanphamDTO sanphamDTO)
        {
            if(!_sanphamService.AddSanPham(sanphamDTO))
            {
                return BadRequest();
            }
            /*return CreatedAtAction("NewSanPham", new { id = sanphamDTO.Id }, sanphamDTO);*/
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSanPham(int id)
        {
            if(!_sanphamService.DeleteSanPham(id))
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateSanPham(SanphamDTO sanphamDTO)
        {
            if(!_sanphamService.UpdateSanPham(sanphamDTO))
            {
                return BadRequest();
            }
            return Ok(sanphamDTO);
        }


        [HttpGet("/Pagning")]
        public async Task<ActionResult<IEnumerable<SanphamDTO>>> Pagning(int pageNumber)
        {
            int pageSize = 5;
            if (context.Sanphams == null)
            {
                return NotFound();
            }
            var sanphams = await context.Sanphams.Select(s => SP(s)).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return sanphams;
        }

        public static SanphamDTO SP(Sanpham sanpham)
        {
            return new SanphamDTO
            {
                Id = sanpham.Id,
                Masanpham = sanpham.Masanpham,
                Tensanpham = sanpham.Tensanpham,
                Kichthuocmanhinh = sanpham.Kichthuocmanhinh,
                Hedieuhanh = sanpham.Hedieuhanh,
                Bonhotrong = sanpham.Bonhotrong,
                Trongluong = sanpham.Trongluong,
                Dungluongpin = sanpham.Dungluongpin,
                Soluongton = sanpham.Soluongton,
                Mota = sanpham.Mota,
                Giaban = sanpham.Giaban,
                Mausac = sanpham.Mausac,
                Baohanh = sanpham.Baohanh,
                Loaisanphamid = sanpham.Loaisanphamid,
                Bonhoram = sanpham.Bonhoram
            };
        }

    }
}
