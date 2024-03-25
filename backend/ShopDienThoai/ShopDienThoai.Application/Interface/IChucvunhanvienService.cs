using ShopDienThoai.Application.DTO;
using ShopDienThoai.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface IChucvunhanvienService
    {
        List<ChucvunhanvienDTO> GetChucvunhanvienList();
        ChucvunhanvienDTO GetChucvunhanvienById(int id);
        bool AddChucvunhanvien(ChucvunhanvienDTO chucvunhanvienDTO);
        bool DeleteChucvunhanvien(int id);
        bool UpdateChucvunhanvien(ChucvunhanvienDTO chucvunhanvienDTO);
    }
}
