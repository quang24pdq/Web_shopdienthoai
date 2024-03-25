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
    public class ChitiethoadonService : IChitiethoadonService
    {
        private readonly IChitiethoadonRepositories _chitiethoadonRepositories;
        private readonly IMapper _mapper;
        public ChitiethoadonService(IChitiethoadonRepositories chitiethoadonRepositories, IMapper mapper)
        {
            _chitiethoadonRepositories = chitiethoadonRepositories;
            _mapper = mapper;
        }

        public bool AddChitiethoadon(ChitiethoadonDTO chitiethoadonDTO)
        {
            return _chitiethoadonRepositories.Add(_mapper.Map<Chitiethoadon>(chitiethoadonDTO));
        }

        public bool DeleteChitiethoadon(int id)
        {
            return _chitiethoadonRepositories.Delete(id);
        }

        public List<ChitiethoadonDTO> GetAllChitiethoadon()
        {
            return _mapper.Map<List<ChitiethoadonDTO>>(_chitiethoadonRepositories.GetAll());
        }

        public ChitiethoadonDTO GetChitiethoadonById(int id)
        {
            return _mapper.Map<ChitiethoadonDTO>(_chitiethoadonRepositories.GetEntity(id));
        }

        public bool UpdateChitiethoadon(ChitiethoadonDTO chitiethoadonDTO)
        {
            return _chitiethoadonRepositories.Update(_mapper.Map<Chitiethoadon>(chitiethoadonDTO));
        }
    }
}
