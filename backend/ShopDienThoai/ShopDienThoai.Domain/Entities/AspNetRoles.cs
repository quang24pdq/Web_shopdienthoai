using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Domain.Entities
{
    public partial class AspNetRoles
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<AspNetRoleClaims> AspNetRoleClaims { get; } = new List<AspNetRoleClaims>();
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; } = new List<AspNetUserRoles>();
    }
}
