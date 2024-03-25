using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Domain.Entities
{
    public partial class AspNetUsers
    {
        public string? Id { get; set; }
        public string UserName { get; set; } = null!;
        public string NormalizedUserName { get; set; } = null!; 
        public string Email { get; set; } = null!;
        public string NormalizedEmail { get; set; } = null!;
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string SecurityStamp { get; set; } = null!;
        public string ConcurrencyStamp { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; } = new List<AspNetUserClaims>();
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; } = new List<AspNetUserLogins>();
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; } = new List<AspNetUserRoles>();
        public virtual ICollection<AspNetUserTokens> AspNetUserTokens { get; } = new List<AspNetUserTokens>();

    }
}
