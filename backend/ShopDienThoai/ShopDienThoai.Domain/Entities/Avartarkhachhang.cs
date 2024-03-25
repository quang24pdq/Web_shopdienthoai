using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Avartarkhachhang
{
    public int Id { get; set; }

    public int? Idkhachhang { get; set; }

    public byte[]? Avartarkhachhang1 { get; set; }

    public virtual Khachhang? IdkhachhangNavigation { get; set; }
}
