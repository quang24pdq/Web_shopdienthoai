using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ShopDienThoai.Application.Interface;
using ShopDienThoai.Application.Interface.System;
using ShopDienThoai.Application.Mapping;
using ShopDienThoai.Application.Services;
using ShopDienThoai.Application.Services.Authenticate;
using ShopDienThoai.Infrastructure.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Application.Modules
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModules(this IServiceCollection services)
        {
            services.AddInfrastructureModule();
            var mapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<ISanPhamService, SanPhamService>();
            services.AddScoped<ILoaisanphamService, LoaisanphamService>();
            services.AddScoped<INhanvienService, NhanvienService>();
            services.AddScoped<IChucvunhanvienService, ChucvunhanvienService>();
            services.AddScoped<IKhachhangService, KhachhangService>();
            services.AddScoped<IBinhluanService, BinhluanService>();
            services.AddScoped<IHoadonService, HoadonService>();
            services.AddScoped<ITinhtrangService, TinhtrangService>();
            services.AddScoped<IPhuongthucthanhtoanService, PhuongthucthanhtoanService>();
            services.AddScoped<IChitiethoadonService, ChitiethoadonService>();
            services.AddScoped<IAccountService, AccountService>();
            return services;
        }
    }
}
