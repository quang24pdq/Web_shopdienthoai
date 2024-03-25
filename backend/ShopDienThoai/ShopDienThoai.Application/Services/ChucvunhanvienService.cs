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
    public class ChucvunhanvienService : IChucvunhanvienService
    {
        private readonly IChucvunhanvienRepositories _chucvunhanvienRepositories;
        private readonly IMapper _mapper;
        public ChucvunhanvienService(IChucvunhanvienRepositories chucvunhanvienRepositories, IMapper mapper)
        {
            _chucvunhanvienRepositories = chucvunhanvienRepositories;
            _mapper = mapper;
        }

        public bool AddChucvunhanvien(ChucvunhanvienDTO chucvunhanvienDTO)
        {
            return _chucvunhanvienRepositories.Add(_mapper.Map<Chucvunhanvien>(chucvunhanvienDTO));
        }

        public bool DeleteChucvunhanvien(int id)
        {
            return _chucvunhanvienRepositories.Delete(id);
        }

        public ChucvunhanvienDTO GetChucvunhanvienById(int id)
        {
            return _mapper.Map<ChucvunhanvienDTO>(_chucvunhanvienRepositories.GetEntity(id));
        }

        public List<ChucvunhanvienDTO> GetChucvunhanvienList()
        {
            return _mapper.Map<List<ChucvunhanvienDTO>>(_chucvunhanvienRepositories.GetAll());
        }

        public bool UpdateChucvunhanvien(ChucvunhanvienDTO chucvunhanvienDTO)
        {
            return _chucvunhanvienRepositories.Update(_mapper.Map<Chucvunhanvien>(chucvunhanvienDTO));
        }
    }
}
