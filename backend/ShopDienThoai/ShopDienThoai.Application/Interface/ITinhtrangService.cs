using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface ITinhtrangService
    {
        List<TinhtrangDTO> GetTinhtrangs();
        TinhtrangDTO GetTinhtrangById(int id);
        bool AddTinhtrang(TinhtrangDTO tinhtrangDTO);
        bool UpdateTinhtrang(TinhtrangDTO tinhtrangDTO);
        bool DeleteTinhtrang(int id);
    }
}
