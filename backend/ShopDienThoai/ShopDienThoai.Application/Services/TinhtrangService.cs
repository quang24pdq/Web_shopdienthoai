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
    public class TinhtrangService : ITinhtrangService
    {
        private readonly ITinhtrangRepositories _tinhtrangRepositories;
        private readonly IMapper _mapper;
        public TinhtrangService(ITinhtrangRepositories tinhtrangRepositories, IMapper mapper)
        {
            _tinhtrangRepositories = tinhtrangRepositories;
            _mapper = mapper;
        }

        public bool AddTinhtrang(TinhtrangDTO tinhtrangDTO)
        {
            return _tinhtrangRepositories.Add(_mapper.Map<Tinhtrang>(tinhtrangDTO));
        }

        public bool DeleteTinhtrang(int id)
        {
            return _tinhtrangRepositories.Delete(id);
        }

        public TinhtrangDTO GetTinhtrangById(int id)
        {
            return _mapper.Map<TinhtrangDTO>(_tinhtrangRepositories.GetEntity(id));
        }

        public List<TinhtrangDTO> GetTinhtrangs()
        {
            return _mapper.Map<List<TinhtrangDTO>>(_tinhtrangRepositories.GetAll());
        }

        public bool UpdateTinhtrang(TinhtrangDTO tinhtrangDTO)
        {
            return _tinhtrangRepositories.Update(_mapper.Map<Tinhtrang>(tinhtrangDTO));
        }
    }
}
