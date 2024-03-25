using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface IChitiethoadonService
    {
        List<ChitiethoadonDTO> GetAllChitiethoadon();
        ChitiethoadonDTO GetChitiethoadonById(int id);
        bool AddChitiethoadon(ChitiethoadonDTO chitiethoadonDTO);
        bool UpdateChitiethoadon(ChitiethoadonDTO chitiethoadonDTO);
        bool DeleteChitiethoadon(int id);
    }
}
