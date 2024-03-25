using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Infrastructure.Context;

namespace ShopDienThoai.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImageSanPhamController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly KinhdoanhdienthoaiContext context;
        public UploadImageSanPhamController(IWebHostEnvironment webHostEnvironment, KinhdoanhdienthoaiContext context)
        {
            this._webHostEnvironment = webHostEnvironment;
            this.context = context;
        }

        /*[HttpPut("DBUploadMultiImage")]
        public async Task<IActionResult> DBUploadMultiImage(IFormFileCollection formFiles, int idsanpham)
        {
            
            int passcount = 0;
            int errorcount = 0;
            try
            {
                foreach (var file in formFiles)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        this.context.Imagesanphams.Add(new Imagesanpham()
                        {
                            Idsanpham = idsanpham,
                            Imagesanpham1 = memoryStream.ToArray()
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
        }*/

        [HttpPut("DBUploadMultiImage")]
        public async Task<IActionResult> DBUploadMultiImage([FromForm] IFormFileCollection formFiles, [FromForm] int idsanpham)
        {
            if (formFiles == null || formFiles.Count == 0)
            {
                return BadRequest("No files uploaded.");
            }
            int successCount = 0;
            int errorCount = 0;
            try
            {
                foreach (var file in formFiles)
                {
                    if (file.Length == 0)
                    {
                        continue; // Bỏ qua các file rỗng
                    }
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);

                        var imageSanPham = new Imagesanpham()
                        {
                            Idsanpham = idsanpham,
                            Imagesanpham1 = memoryStream.ToArray()
                        };

                        this.context.Imagesanphams.Add(imageSanPham);
                        await this.context.SaveChangesAsync();
                        successCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                errorCount++;
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
            if (successCount > 0)
            {
                return Ok($"{successCount} image(s) uploaded successfully.");
            }
            return BadRequest("No valid files uploaded.");
        }

        /*[HttpGet("GetAllImageProduct")]
        public async Task<IActionResult> GetAllImageProduct()
        {
            List<string> ImgUrl = new List<string>();
            try
            {
                if (this.context.Imagesanphams == null)
                {
                    return NotFound();
                }
                else
                {
                    var allImg = this.context.Imagesanphams.Select(s => s.Imagesanpham1).ToList();
                    if(allImg != null)
                    {
                        allImg.ForEach(s =>
                        {
                            ImgUrl.Add(Convert.ToBase64String(s));
                        });
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok(ImgUrl);
            
        }*/

        [HttpGet("GetAllImageProduct")]
        public async Task<IActionResult> GetAllImageProduct()
        {
            try
            {
                var imagesWithProductIds = await this.context.Imagesanphams
                    .Where(i => i.Imagesanpham1 != null && i.Imagesanpham1.Length > 0)
                    .ToListAsync();

                var result = imagesWithProductIds.Select(image => new
                {
                    Id = image.Id,
                    Idsanpham = image.Idsanpham,
                    ImageUrl = Convert.ToBase64String(image.Imagesanpham1)
                });

                return Ok(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("RemoveImage")]
        public async Task<IActionResult> RemoveImage(int idsanpham)
        {
            var img = this.context.Imagesanphams.Where(e => e.Idsanpham == idsanpham).FirstOrDefault();
            try
            {
                if(img != null)
                {
                    this.context.Imagesanphams.Remove(img);
                    await context.SaveChangesAsync();
                    return Ok();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return NotFound();
            }
            return NotFound();
        }

        /*[HttpGet("RemoveMultiImage")]
        public async Task<IActionResult> RemoveMultiImage(int idsanpham)
        {

        }*/

        [HttpGet("DBGetMultiImage")]
        public async Task<IActionResult> DBGetMultiImage(int idsanpham)
        {
            List<string> ImageUrl = new List<string>();
            try
            {
                var _sanphamImage = this.context.Imagesanphams.Where(item => item.Idsanpham == idsanpham).ToList();
                if (_sanphamImage != null && _sanphamImage.Count > 0)
                {
                    _sanphamImage.ForEach(async item =>
                    {
                        ImageUrl.Add(Convert.ToBase64String(item.Imagesanpham1));
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

        /*[NonAction]
        private string GetFilePath(int manhanvien)
        {
            return this._webHostEnvironment.WebRootPath + "\\Upload\\nhanvien\\" + manhanvien;
        }*/
    }
}
