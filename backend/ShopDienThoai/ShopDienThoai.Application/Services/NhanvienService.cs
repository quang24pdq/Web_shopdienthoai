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
    public class NhanvienService : INhanvienService
    {
        private readonly INhanvienRepositories _nhanvienRepositories;
        private readonly IMapper _mapper;
        public NhanvienService(INhanvienRepositories nhanvienRepositories, IMapper mapper)
        {
            _nhanvienRepositories = nhanvienRepositories;
            _mapper = mapper;
        }

        public bool AddNhanVien(NhanvienDTO nhanvienDTO)
        {
            return _nhanvienRepositories.Add(_mapper.Map<Nhanvien>(nhanvienDTO));
        }

        public bool DeleteNhanvien(int id)
        {
            return _nhanvienRepositories.Delete(id);
        }

        public List<NhanvienDTO> GetAllNhanVien()
        {
            return _mapper.Map<List<NhanvienDTO>>(_nhanvienRepositories.GetAll());
        }

        public NhanvienDTO GetNhanvien(int id)
        {
            return _mapper.Map<NhanvienDTO>(_nhanvienRepositories.GetEntity(id));
        }

        public bool UpdateNhanVien(NhanvienDTO nhanvienDTO)
        {
            return _nhanvienRepositories.Update(_mapper.Map<Nhanvien>(nhanvienDTO));
        }
    }
}
