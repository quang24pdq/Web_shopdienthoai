using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface IBinhluanService
    {
        List<BinhluanDTO> GetAllBinhluan();
        BinhluanDTO GetBinhluanById(int id);
        bool AddBinhluan(BinhluanDTO binhluanDTO);
        bool UpdateBinhluan(BinhluanDTO binhluanDTO);
        bool DeleteBinhluan(int id);
    }
}
