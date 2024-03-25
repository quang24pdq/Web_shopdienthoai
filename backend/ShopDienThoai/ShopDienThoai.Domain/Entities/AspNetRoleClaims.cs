using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Domain.Entities
{
    public partial class AspNetRoleClaims
    {
        public int Id { get; set; }
        public string RoleId { get; set; } = null!;
        public string? ClaimType { get; set; }
        public string ClaimValue { get; set;} = null!;
        public virtual AspNetRoles Roles { get; set; } = null!;
    }
}
