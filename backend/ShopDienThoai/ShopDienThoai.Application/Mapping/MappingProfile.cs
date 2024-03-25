using AutoMapper;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.DTO.System;
using ShopDienThoai.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Sanpham, SanphamDTO>().ReverseMap();
            CreateMap<Loaisanpham, LoaisanphamDTO>().ReverseMap();
            CreateMap<Nhanvien, NhanvienDTO>().ReverseMap();
            CreateMap<Chucvunhanvien, ChucvunhanvienDTO>().ReverseMap();
            CreateMap<Khachhang, KhachhangDTO>().ReverseMap();
            CreateMap<Binhluan, BinhluanDTO>().ReverseMap();
            CreateMap<Hoadon, HoadonDTO>().ReverseMap();
            CreateMap<Tinhtrang, TinhtrangDTO>().ReverseMap();
            CreateMap<Phuongthucthanhtoan, PhuongthucthanhtoanDTO>().ReverseMap();
            CreateMap<Chitiethoadon, ChitiethoadonDTO>().ReverseMap();
            CreateMap<Imagenhanvien, ImageNhanVienDTO>().ReverseMap();

            CreateMap<AspNetRoles, AspNetRoleDTO>().ReverseMap();

        }
    }
}
