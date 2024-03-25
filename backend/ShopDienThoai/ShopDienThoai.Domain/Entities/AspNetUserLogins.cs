using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Domain.Entities
{
    public partial class AspNetUserLogins
    {
        public string? LoginProvider { get; set; }
        public string? ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public virtual AspNetUsers AspNetUsers { get; set; } = null!;
    }
}
