using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Auth
{
    public class SignInResponse
    {
        public string? Id { get; set; }
        public string? Username { get; set;}
        public string? FullName { get; set; }
        public string? Permissions { get; set; }
        public string? Token { get; set; }
        public string? SSOToken { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool IsSuccess { get; set; }
        public string? ErrMessages { get; set; }
    }
}
