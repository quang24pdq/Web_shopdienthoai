using Microsoft.Extensions.DependencyInjection;
using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Domain.Repositories;
using ShopDienThoai.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Infrastructure.Modules
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureModule(this IServiceCollection services)
        {
            services.AddScoped<ISanphamRepositories, SanPhamRepositories>();
            services.AddScoped<ILoaisanphamRepositories, LoaisanphamRepositories>();
            services.AddScoped<INhanvienRepositories, NhanvienRepositories>();
            services.AddScoped<IChucvunhanvienRepositories, ChucvunhanvienRepositories>();
            services.AddScoped<IKhachangRepositories, KhachhangRepositories>();
            services.AddScoped<IBinhluanRepositories, BinhluanRepositories>();
            services.AddScoped<IHoadonRepositories, HoadonRepositories>();
            services.AddScoped<ITinhtrangRepositories, TinhtrangRepositories>();
            services.AddScoped<IPhuongthucthanhtoanRepositories, PhuongthucthanhtoanRepositories>();
            services.AddScoped<IChitiethoadonRepositories, ChitiethoadonRepositories>();
            return services;
        }
    }
}
