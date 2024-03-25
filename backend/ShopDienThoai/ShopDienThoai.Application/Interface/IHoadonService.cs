using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface IHoadonService
    {
        List<HoadonDTO> GetAllHoadon();
        HoadonDTO GetHoadonById(int id);
        bool AddHoadon(HoadonDTO hoadonDTO);
        bool UpdateHoadon(HoadonDTO hoadonDTO);
        bool DeleteHoadon(int id);
    }
}
