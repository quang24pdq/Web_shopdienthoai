using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Infrastructure.Context;
using System.Drawing;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImageNhanVienController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly KinhdoanhdienthoaiContext context;
        public UploadImageNhanVienController(IWebHostEnvironment webHostEnvironment, KinhdoanhdienthoaiContext context)
        {
            this._webHostEnvironment = webHostEnvironment;
            this.context = context;
        }

        [HttpPut("DBUploadMultiImage")]
        public async Task<IActionResult> DBUploadMultiImage(IFormFileCollection formFiles, int manhanvien)
        {
            /*APIResponse response = new APIResponse();*/
            int passcount = 0;
            int errorcount = 0;
            try
            {
                foreach (var file in formFiles)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        this.context.Imagenhanviens.Add(new Imagenhanvien()
                        {
                            Idnhanvien = manhanvien,
                            Imagestaff = memoryStream.ToArray()
                        });
                        await this.context.SaveChangesAsync();
                        passcount++;
                    }
                }
            }
            catch (Exception ex)
            {
                errorcount++;
                Console.WriteLine(ex.Message);
            }
            return Ok();
        }

        [HttpGet("DBGetMultiImage")]
        public async Task<IActionResult> DBGetMultiImage(int manhanvien)
        {
            List<string> ImageUrl = new List<string>(); 
            try
            {
                var _nhanvienImage = this.context.Imagenhanviens.Where(item => item.Idnhanvien == manhanvien).ToList();
                if( _nhanvienImage != null && _nhanvienImage.Count > 0)
                {
                    _nhanvienImage.ForEach(item =>
                    {
                        ImageUrl.Add(Convert.ToBase64String(item.Imagestaff));
                    });
                } 
                else
                {
                    return NotFound();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok(ImageUrl);
        }

        [NonAction]
        private string GetFilePath(int manhanvien)
        {
            return this._webHostEnvironment.WebRootPath + "\\Upload\\nhanvien\\" + manhanvien;
        }
    }
}
