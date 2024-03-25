using Microsoft.AspNetCore.Identity;
using ShopDienThoai.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Interface.System
{
    public interface IAccountService
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        public Task<string> SignInAsync(SignInModel signInModel);
    }
}
