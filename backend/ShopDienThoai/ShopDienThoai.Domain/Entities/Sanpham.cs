using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Sanpham
{
    public int Id { get; set; }

    public string Masanpham { get; set; } = null!;

    public string? Tensanpham { get; set; }

    public string? Kichthuocmanhinh { get; set; }

    public string? Hedieuhanh { get; set; }

    public string? Bonhotrong { get; set; }

    public string? Trongluong { get; set; }

    public string? Dungluongpin { get; set; }

    public int? Soluongton { get; set; }

    /*public string? Anhsanpham { get; set; }*/

    public string? Mota { get; set; }

    public int? Giaban { get; set; }

    public string? Mausac { get; set; }

    public string? Baohanh { get; set; }

    public int? Loaisanphamid { get; set; }

    public string? Bonhoram { get; set; }

    public virtual ICollection<Binhluan> Binhluans { get; set; } = new List<Binhluan>();

    public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; } = new List<Chitiethoadon>();

    public virtual ICollection<Imagesanpham> Imagesanphams { get; set; } = new List<Imagesanpham>();

    public virtual Loaisanpham? Loaisanpham { get; set; }
}
