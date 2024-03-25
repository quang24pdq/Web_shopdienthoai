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
    public class PhuongthucthanhtoanService : IPhuongthucthanhtoanService
    {
        private readonly IPhuongthucthanhtoanRepositories _phuongthucthanhtoanRepositories;
        private readonly IMapper _mapper;
        public PhuongthucthanhtoanService(IPhuongthucthanhtoanRepositories phuongthucthanhtoanRepositories, IMapper mapper)
        {
            _phuongthucthanhtoanRepositories = phuongthucthanhtoanRepositories;
            _mapper = mapper;
        }

        public bool AddPhuongthucthanhtoan(PhuongthucthanhtoanDTO phuongthucthanhtoanDTO)
        {
            return _phuongthucthanhtoanRepositories.Add(_mapper.Map<Phuongthucthanhtoan>(phuongthucthanhtoanDTO));
        }

        public bool DeletePhuongthucthanhtoan(int id)
        {
            return _phuongthucthanhtoanRepositories.Delete(id);
        }

        public List<PhuongthucthanhtoanDTO> GetAllPhuongthucthanhtoan()
        {
            return _mapper.Map<List<PhuongthucthanhtoanDTO>>(_phuongthucthanhtoanRepositories.GetAll());
        }

        public PhuongthucthanhtoanDTO GetPhuongthucthanhtoanById(int id)
        {
            return _mapper.Map<PhuongthucthanhtoanDTO>(_phuongthucthanhtoanRepositories.GetEntity(id));
        }

        public bool UpdatePhuongthucthanhtoan(PhuongthucthanhtoanDTO phuongthucthanhtoanDTO)
        {
            return _phuongthucthanhtoanRepositories.Update(_mapper.Map<Phuongthucthanhtoan>(phuongthucthanhtoanDTO));
        }
    }
}
