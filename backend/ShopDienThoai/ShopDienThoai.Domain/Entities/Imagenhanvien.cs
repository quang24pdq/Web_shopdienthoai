using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Imagenhanvien
{
    public int Id { get; set; }

    public int? Idnhanvien { get; set; }

    public byte[]? Imagestaff { get; set; }

    public virtual Nhanvien? IdnhanvienNavigation { get; set; }
}
