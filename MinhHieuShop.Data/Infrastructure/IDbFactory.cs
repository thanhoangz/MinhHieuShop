using System;

namespace MinhHieuShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        MinhHieuShopDbContext Init();
    }
}