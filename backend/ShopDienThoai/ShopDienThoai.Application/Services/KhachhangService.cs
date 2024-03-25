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
    public class KhachhangService : IKhachhangService
    {
        private readonly IKhachangRepositories _khachangRepositories;
        private readonly IMapper _mapper;
        public KhachhangService(IKhachangRepositories khachangRepositories, IMapper mapper)
        {
            _khachangRepositories = khachangRepositories;
            _mapper = mapper;
        }

        public bool AddKhachhang(KhachhangDTO khachhangDTO)
        {
            return _khachangRepositories.Add(_mapper.Map<Khachhang>(khachhangDTO));
        }

        public bool DeleteKhachhang(int id)
        {
            return _khachangRepositories.Delete(id);
        }

        public List<KhachhangDTO> GetAllKhachhang()
        {
            return _mapper.Map<List<KhachhangDTO>>(_khachangRepositories.GetAll());
        }

        public KhachhangDTO GetKhachhangById(int id)
        {
            return _mapper.Map<KhachhangDTO>(_khachangRepositories.GetEntity(id));
        }

        public bool UpdateKhachhang(KhachhangDTO khachhangDTO)
        {
            return _khachangRepositories.Update(_mapper.Map<Khachhang>(khachhangDTO));
        }
    }
}
