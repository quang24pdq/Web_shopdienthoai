using ShopDienThoai.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface
{
    public interface IPhuongthucthanhtoanService
    {
        List<PhuongthucthanhtoanDTO> GetAllPhuongthucthanhtoan();
        PhuongthucthanhtoanDTO GetPhuongthucthanhtoanById(int id);
        bool AddPhuongthucthanhtoan(PhuongthucthanhtoanDTO phuongthucthanhtoanDTO);
        bool UpdatePhuongthucthanhtoan(PhuongthucthanhtoanDTO phuongthucthanhtoanDTO);
        bool DeletePhuongthucthanhtoan(int id);

    }
}
