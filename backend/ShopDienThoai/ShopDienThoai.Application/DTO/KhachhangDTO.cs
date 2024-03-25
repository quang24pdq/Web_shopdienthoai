using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.DTO
{
    public class KhachhangDTO
    {
        public int Id { get; set; }

        public string Makhachhang { get; set; } = null!;

        public string? Tenkhachhang { get; set; }

        public string? Diachi { get; set; }

        public string? Sdt { get; set; }

        /*public string? Avartar { get; set; }*/

        public string? Email { get; set; }
    }
}
