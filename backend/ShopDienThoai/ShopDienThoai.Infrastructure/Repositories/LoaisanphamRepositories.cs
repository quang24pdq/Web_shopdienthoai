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
    public class LoaisanphamRepositories : Repositories<Loaisanpham>, ILoaisanphamRepositories
    {
        public LoaisanphamRepositories(KinhdoanhdienthoaiContext context) : base(context) { }
    }
}
