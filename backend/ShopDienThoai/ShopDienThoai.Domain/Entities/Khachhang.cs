using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Khachhang
{
    public int Id { get; set; }

    public string Makhachhang { get; set; } = null!;

    public string? Tenkhachhang { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

   /* public string? Avartar { get; set; }*/

    public string? Email { get; set; }

    public virtual ICollection<Avartarkhachhang> Avartarkhachhangs { get; set; } = new List<Avartarkhachhang>();

    public virtual ICollection<Binhluan> Binhluans { get; set; } = new List<Binhluan>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
