﻿using ShopDienThoai.Domain.Entities;
using ShopDienThoai.Domain.Repositories;
using ShopDienThoai.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDienThoai.Infrastructure.Repositories
{
    public class HoadonRepositories : Repositories<Hoadon>, IHoadonRepositories
    {
        public HoadonRepositories(KinhdoanhdienthoaiContext context) : base(context) { }
    }
}
