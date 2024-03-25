using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Chucvunhanvien
{
    public int Id { get; set; }

    public string? Tenchucvu { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
