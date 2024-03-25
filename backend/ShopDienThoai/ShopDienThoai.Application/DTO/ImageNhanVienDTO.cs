using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.DTO
{
    public class ImageNhanVienDTO
    {
        public int Id { get; set; }

        public int? Idnhanvien { get; set; }

        public byte[]? ImageNhanVien { get; set; }
    }
}
