using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface IKhachhangService
    {
        List<KhachhangDTO> GetAllKhachhang();
        KhachhangDTO GetKhachhangById(int id);
        bool AddKhachhang(KhachhangDTO khachhangDTO);
        bool UpdateKhachhang(KhachhangDTO khachhangDTO);
        bool DeleteKhachhang(int id);
    }
}
