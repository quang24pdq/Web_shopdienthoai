using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Loaisanpham
{
    public int Id { get; set; }

    public string Tenloaisanpham { get; set; } = null!;

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
