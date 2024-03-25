using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Phuongthucthanhtoan
{
    public int Id { get; set; }

    public string? Tenphuongthuc { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
