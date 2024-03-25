using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Imagesanpham
{
    public int Id { get; set; }

    public int? Idsanpham { get; set; }

    public byte[]? Imagesanpham1 { get; set; }

    public virtual Sanpham? IdsanphamNavigation { get; set; }
}
