using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanvienService _nhanvienService;
        public NhanVienController(INhanvienService nhanvienService)
        {
            _nhanvienService = nhanvienService;
        }
        [HttpGet]
        public IActionResult GetAllNhanVien()
        {
            return Ok(_nhanvienService.GetAllNhanVien());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetNhanVienById(int id)
        {
            var nhanvien = _nhanvienService.GetNhanvien(id);
            if(nhanvien == null)
            {
                return NotFound();
            }
            return Ok(nhanvien);
        }
        [HttpPost]
        public IActionResult ThemNhanVien(NhanvienDTO nhanvienDTO)
        {
            if (!_nhanvienService.AddNhanVien(nhanvienDTO))
            {
                return BadRequest();
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNhanVien(int id)
        {
            if(_nhanvienService.DeleteNhanvien(id))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateNhanvien(NhanvienDTO nhanvien)
        {
            if(!_nhanvienService.UpdateNhanVien(nhanvien))
            {
                return BadRequest();
            }
            return Ok(nhanvien);
        }
        /*[HttpPost]
        public IActionResult ThemNhanVien([Bind("Id, Manhanvien, Hoten, Ngaysinh, Diachi, Sdt, Avartar, Email, Chucvuid, GioiTinh")] NhanvienDTO nhanvienDTO, IFormFile formFile)
        {
            string fileName = UploadIMG(nhanvienDTO.Manhanvien, formFile);
            if (!_nhanvienService.AddNhanVien(new NhanvienDTO
            {
                Id = nhanvienDTO.Id,
                Manhanvien = nhanvienDTO.Manhanvien,
                Hoten = nhanvienDTO.Hoten,
                Ngaysinh = nhanvienDTO.Ngaysinh,
                Diachi = nhanvienDTO.Diachi,
                Sdt = nhanvienDTO.Sdt,
                Avartar = fileName,
                Email = nhanvienDTO.Email,
                Chucvuid = nhanvienDTO.Chucvuid,
                GioiTinh = nhanvienDTO.GioiTinh
            })){
                return BadRequest();
            }
            *//*if (!_nhanvienService.AddNhanVien(nhanvienDTO))
            {
                return BadRequest();
            }*//*
            return NoContent();
        }*/
        private string UploadIMG(string mnv, IFormFile formFile)
        {
            string path = Path.GetFullPath("./Image/ImageNhanVien");
            path = path + "/" + mnv;
            Directory.CreateDirectory(path);
            string filePath = path + "/" + formFile.FileName;
            using var stream = new FileStream(filePath, FileMode.Create);
            formFile.CopyTo(stream);
            return mnv + "/" + formFile.FileName;
        }
    }
}
