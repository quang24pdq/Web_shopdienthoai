using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.DTO
{
    public class NhanvienDTO
    {
        public int Id { get; set; }

        public string Manhanvien { get; set; } = null!;

        public string? Hoten { get; set; }

        public DateTime? Ngaysinh { get; set; }

        public string? Diachi { get; set; }

        public string? Sdt { get; set; }

        public string? Email { get; set; }

        public int? Chucvuid { get; set; }

        public bool? GioiTinh { get; set; }

    }
}
