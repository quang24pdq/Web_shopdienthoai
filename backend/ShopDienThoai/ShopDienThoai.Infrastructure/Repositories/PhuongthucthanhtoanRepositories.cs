using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Domain.Repositories;
using ShopDienThoai.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Infrastructure.Repositories
{
    public class PhuongthucthanhtoanRepositories : Repositories<Phuongthucthanhtoan>, IPhuongthucthanhtoanRepositories
    {
        public PhuongthucthanhtoanRepositories(KinhdoanhdienthoaiContext context) : base(context) { }
    }
}
