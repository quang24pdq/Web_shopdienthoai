using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Domain.Repositories;
using ShopDienThoai.Infrastructure.Context;

namespace ShopDienThoai.Infrastructure.Repositories
{
    public class ChitiethoadonRepositories : Repositories<Chitiethoadon>, IChitiethoadonRepositories
    {
        public ChitiethoadonRepositories(KinhdoanhdienthoaiContext context) : base(context) { }
    }
}
