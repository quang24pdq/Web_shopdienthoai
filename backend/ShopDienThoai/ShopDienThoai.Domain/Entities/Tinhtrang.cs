using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Tinhtrang
{
    public int Id { get; set; }

    public string? Tentinhtrang { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
