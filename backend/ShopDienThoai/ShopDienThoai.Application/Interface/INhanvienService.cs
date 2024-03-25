using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface INhanvienService
    {
        List<NhanvienDTO> GetAllNhanVien();
        NhanvienDTO GetNhanvien(int id);
        bool AddNhanVien(NhanvienDTO nhanvien);
        bool UpdateNhanVien(NhanvienDTO nhanvien);
        bool DeleteNhanvien(int id);

        /* Task<List<NhanvienDTO>> GetAllNhanVien();
         Task<NhanvienDTO> GetNhanvien(int id);
         Task DeleteNhanvienAsync(int id);
         Task UpdateNhanVienAsync(NhanvienDTO nhanvien);
         Task AddNhanVienAsync(NhanvienDTO nhanvien);*/
    }
}
