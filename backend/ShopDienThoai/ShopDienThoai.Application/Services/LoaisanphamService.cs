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
    public class LoaisanphamService : ILoaisanphamService
    {
        private readonly ILoaisanphamRepositories _loaisanphamRepo;
        private readonly IMapper _mapper;
        public LoaisanphamService(ILoaisanphamRepositories loaisanphamRepo, IMapper mapper)
        {
            _loaisanphamRepo = loaisanphamRepo;
            _mapper = mapper;
        }
        public bool AddLoaiSanPham(LoaisanphamDTO loaisanphamDTO)
        {
            return _loaisanphamRepo.Add(_mapper.Map<Loaisanpham>(loaisanphamDTO));
        }
        public bool DeleteLoaiSanPham(int id)
        {
            return _loaisanphamRepo.Delete(id);
        }
        public LoaisanphamDTO GetLoaisanphamById(int id)
        {
            return _mapper.Map<LoaisanphamDTO>(_loaisanphamRepo.GetEntity(id));
        }
        public bool UpdateLoaiSanPham(LoaisanphamDTO loaisanphamDTO)
        {
            return _loaisanphamRepo.Update(_mapper.Map<Loaisanpham>(loaisanphamDTO));
        }

        public List<LoaisanphamDTO> GetLoaisanphams()
        {
            return _mapper.Map<List<LoaisanphamDTO>>(_loaisanphamRepo.GetAll());
        }
    }
}
