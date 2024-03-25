using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.DTO
{
    public class HoadonDTO
    {
        public int Id { get; set; }

        public DateTime? Ngaydathang { get; set; }

        public DateTime? Ngaygiaohang { get; set; }

        public string? Diachigiaohang { get; set; }

        public int? Idkhachhang { get; set; }

        public int? Idnhanvien { get; set; }

        public int? Idphuongthuc { get; set; }

        public int? Idtinhtrang { get; set; }
    }
}
