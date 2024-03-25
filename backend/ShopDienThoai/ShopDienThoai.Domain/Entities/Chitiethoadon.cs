using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Chitiethoadon
{
    public int Id { get; set; }

    public int? Idhoadon { get; set; }

    public int? Idsanpham { get; set; }

    public int? Soluong { get; set; }

    public int? Dongia { get; set; }

    public int? Thanhtien { get; set; }

    public virtual Hoadon? IdhoadonNavigation { get; set; }

    public virtual Sanpham? IdsanphamNavigation { get; set; }
}
