using ShopDienThoai.Application.DTO.System;
using ShopDienThoai.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface.System
{
    public interface IRoleService
    {
        Task<AspNetRoleDTO> GetRoleAsync(string roleId);
        Task<string> SaveRoleAsync(AspNetRoleDTO role);
        Task DeleteRoleAsync(string roleId);
        Task UpdateRoleAsync(AspNetRoleDTO role);
        Task<List<AspNetRoleDTO>> GetAllRolesAsync();

    }
}
