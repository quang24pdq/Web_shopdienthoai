using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Binhluan
{
    public int Id { get; set; }

    public int? Idkhachhang { get; set; }

    public int? Idsanpham { get; set; }

    public string? Noidungbinhluan { get; set; }

    public DateTime? Thoigianbinhluan { get; set; }

    public virtual Khachhang? IdkhachhangNavigation { get; set; }

    public virtual Sanpham? IdsanphamNavigation { get; set; }
}
