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
    public class BinhluanService : IBinhluanService
    {
        private readonly IBinhluanRepositories _binhluanRepositories;
        private readonly IMapper _mapper;
        public BinhluanService(IBinhluanRepositories binhluanRepositories, IMapper mapper)
        {
            _binhluanRepositories = binhluanRepositories;
            _mapper = mapper;
        }

        public bool AddBinhluan(BinhluanDTO binhluanDTO)
        {
            return _binhluanRepositories.Add(_mapper.Map<Binhluan>(binhluanDTO));
        }

        public bool DeleteBinhluan(int id)
        {
            return _binhluanRepositories.Delete(id);
        }

        public List<BinhluanDTO> GetAllBinhluan()
        {
            return _mapper.Map<List<BinhluanDTO>>(_binhluanRepositories.GetAll());
        }

        public BinhluanDTO GetBinhluanById(int id)
        {
            return _mapper.Map<BinhluanDTO>(_binhluanRepositories.GetEntity(id));
        }

        public bool UpdateBinhluan(BinhluanDTO binhluanDTO)
        {
            return _binhluanRepositories.Update(_mapper.Map<Binhluan>(binhluanDTO));
        }
    }
}
