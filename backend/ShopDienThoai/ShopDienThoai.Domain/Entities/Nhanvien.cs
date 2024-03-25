using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Nhanvien
{
    public int Id { get; set; }

    public string Manhanvien { get; set; } = null!;

    public string? Hoten { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public int? Chucvuid { get; set; }

    public bool? Gioitinh { get; set; }

    public virtual Chucvunhanvien? Chucvu { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Imagenhanvien> Imagenhanviens { get; set; } = new List<Imagenhanvien>();
}
