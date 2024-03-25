using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Domain.Entities
{
    public partial class AspNetUserRoles
    {
        public string UserId { get; set; } = null!;
        public string RoleId { get; set; } = null!;
        public virtual AspNetRoles AspNetRoles { get; set; } = null!;
        public virtual AspNetUsers AspNetUsers { get; set; } = null!;
    }
}
