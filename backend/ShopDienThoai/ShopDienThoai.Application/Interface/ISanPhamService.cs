using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface ISanPhamService
    {
        List<SanphamDTO> GetSanphams();
        SanphamDTO GetSanPhamById(int id);
        bool AddSanPham(SanphamDTO sanpham);
        bool UpdateSanPham(SanphamDTO sanpham);
        bool DeleteSanPham(int id);

        
    }
}
