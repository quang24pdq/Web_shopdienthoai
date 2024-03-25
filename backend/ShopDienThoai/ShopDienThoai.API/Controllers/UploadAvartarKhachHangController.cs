using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Infrastructure.Context;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadAvartarKhachHangController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly KinhdoanhdienthoaiContext context;
        public UploadAvartarKhachHangController(IWebHostEnvironment webHostEnvironment, KinhdoanhdienthoaiContext context)
        {
            this._webHostEnvironment = webHostEnvironment;
            this.context = context;
        }

        [HttpPut("DBUploadMultiImage")]
        public async Task<IActionResult> DBUploadMultiImage(IFormFileCollection formFiles, int idkhachhang)
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
                        this.context.Avartarkhachhangs.Add(new Avartarkhachhang()
                        {
                            Idkhachhang = idkhachhang,
                            Avartarkhachhang1 = memoryStream.ToArray()
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
        public async Task<IActionResult> DBGetMultiImage(int idkhachhang)
        {
            List<string> ImageUrl = new List<string>();
            try
            {
                var _avartar = this.context.Avartarkhachhangs.Where(item => item.Idkhachhang == idkhachhang).ToList();
                if (_avartar != null && _avartar.Count > 0)
                {
                    _avartar.ForEach(item =>
                    {
                        ImageUrl.Add(Convert.ToBase64String(item.Avartarkhachhang1));
                    });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok(ImageUrl);
        }
    }
}
