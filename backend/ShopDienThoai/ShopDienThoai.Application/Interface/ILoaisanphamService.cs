using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface ILoaisanphamService
    {
        List<LoaisanphamDTO> GetLoaisanphams();
        LoaisanphamDTO GetLoaisanphamById(int id);
        bool AddLoaiSanPham(LoaisanphamDTO loaisanphamDTO);
        bool UpdateLoaiSanPham(LoaisanphamDTO loaisanphamDTO);
        bool DeleteLoaiSanPham(int id);

        /*Task<List<LoaisanphamDTO>> GetLoaisanphamList();
        Task<LoaisanphamDTO> GetLoaisanphamAsync(int id);
        Task<string> AddLoaiSanPhamAsync(LoaisanphamDTO entity);
        Task UpdateLoaiSanPhamAsync(LoaisanphamDTO loaisanpham);
        Task DeleteLoaiSanPhamAsync(int id);*/
    }
}
