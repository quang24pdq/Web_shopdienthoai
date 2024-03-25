using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.DTO
{
    public class BinhluanDTO
    {
        public int Id { get; set; }

        public int? Idkhachhang { get; set; }

        public int? Idsanpham { get; set; }

        public string? Noidungbinhluan { get; set; }

        public DateTime? Thoigianbinhluan { get; set; }
    }
}
