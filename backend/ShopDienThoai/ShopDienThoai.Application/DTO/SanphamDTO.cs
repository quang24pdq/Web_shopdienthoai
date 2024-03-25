using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.DTO
{
    public class SanphamDTO
    {
        public int Id { get; set; }

        public string Masanpham { get; set; } = null!;

        public string? Tensanpham { get; set; }

        public string? Kichthuocmanhinh { get; set; }

        public string? Hedieuhanh { get; set; }

        public string? Bonhotrong { get; set; }

        public string? Trongluong { get; set; }

        public string? Dungluongpin { get; set; }

        public int? Soluongton { get; set; }

        /*public string? Anhsanpham { get; set; }*/

        public string? Mota { get; set; }

        public int? Giaban { get; set; }

        public string? Mausac { get; set; }

        public string? Baohanh { get; set; }

        public int? Loaisanphamid { get; set; }

        public string? Bonhoram { get; set; }
    }
}
