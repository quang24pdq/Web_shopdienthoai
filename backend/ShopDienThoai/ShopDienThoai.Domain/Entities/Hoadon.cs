using System;
using System.Collections.Generic;

namespace ShopDienThoai.Domain.Entities;

public partial class Hoadon
{
    public int Id { get; set; }

    public DateTime? Ngaydathang { get; set; }

    public DateTime? Ngaygiaohang { get; set; }

    public string? Diachigiaohang { get; set; }

    public int? Idkhachhang { get; set; }

    public int? Idnhanvien { get; set; }

    public int? Idphuongthuc { get; set; }

    public int? Idtinhtrang { get; set; }

    public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; } = new List<Chitiethoadon>();

    public virtual Khachhang? IdkhachhangNavigation { get; set; }

    public virtual Nhanvien? IdnhanvienNavigation { get; set; }

    public virtual Phuongthucthanhtoan? IdphuongthucNavigation { get; set; }

    public virtual Tinhtrang? IdtinhtrangNavigation { get; set; }
}
