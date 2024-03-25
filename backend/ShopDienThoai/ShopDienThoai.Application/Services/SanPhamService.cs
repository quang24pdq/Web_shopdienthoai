using AutoMapper;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Services
{
    public class SanPhamService : ISanPhamService
    {
        private readonly ISanphamRepositories _sanPhamRepo;
        private readonly IMapper _mapper;
        public SanPhamService(ISanphamRepositories sanPhamRepo, IMapper mapper)
        {
            _sanPhamRepo = sanPhamRepo;
            _mapper = mapper;
        }

        public bool AddSanPham(SanphamDTO sanphamDTO)
        {
            return _sanPhamRepo.Add(_mapper.Map<Sanpham>(sanphamDTO));
        }

        public bool DeleteSanPham(int id)
        {
            return _sanPhamRepo.Delete(id);
        }

        public SanphamDTO GetSanPhamById(int id)
        {
            return _mapper.Map<SanphamDTO>(_sanPhamRepo.GetEntity(id));
        }

        public List<SanphamDTO> GetSanphams()
        {
            return _mapper.Map<List<SanphamDTO>>(_sanPhamRepo.GetAll());
        }

        public bool UpdateSanPham(SanphamDTO sanphamDTO)
        {
            return _sanPhamRepo.Update(_mapper.Map<Sanpham>(sanphamDTO));
        }
    }
}
