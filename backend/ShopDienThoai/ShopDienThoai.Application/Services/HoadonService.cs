using AutoMapper;
using ShopDienThoai.Application.DTO;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Domain.Repositories;
using ShopDienThoai.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Services
{
    public class HoadonService : IHoadonService
    {
        private readonly IHoadonRepositories _hoadonRepositories;
        private readonly IMapper _mapper;
        public HoadonService(IHoadonRepositories hoadonRepositories, IMapper mapper)
        {
            _hoadonRepositories = hoadonRepositories;
            _mapper = mapper;
        }
        public bool AddHoadon(HoadonDTO hoadonDTO)
        {
            return _hoadonRepositories.Add(_mapper.Map<Hoadon>(hoadonDTO));
        }

        public bool DeleteHoadon(int id)
        {
            return _hoadonRepositories.Delete(id);
        }

        public List<HoadonDTO> GetAllHoadon()
        {
            return _mapper.Map<List<HoadonDTO>>(_hoadonRepositories.GetAll());
        }

        public HoadonDTO GetHoadonById(int id)
        {
            return _mapper.Map<HoadonDTO>(_hoadonRepositories.GetEntity(id));
        }

        public bool UpdateHoadon(HoadonDTO hoadonDTO)
        {
            return _hoadonRepositories.Update(_mapper.Map<Hoadon>(hoadonDTO));
        }
    }
}
