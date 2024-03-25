using AutoMapper;
using ShopDienThoai.Application.DTO.System;
using ShopDienThoai.Application.Interface.System;
using ShopDienThoai.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Services.Identity
{
    public class RoleService : IRoleService
    {
        private readonly KinhdoanhdienthoaiContext context;
        private readonly IMapper mapper;

        public RoleService(KinhdoanhdienthoaiContext context, IMapper mapper) 
        {
            this.context = context;
            this.mapper = mapper;
        }
        public Task DeleteRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AspNetRoleDTO>> GetAllRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AspNetRoleDTO> GetRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public Task<string> SaveRoleAsync(AspNetRoleDTO role)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoleAsync(AspNetRoleDTO role)
        {
            throw new NotImplementedException();
        }
    }
}
