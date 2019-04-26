
namespace MinhHieuShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private MinhHieuShopDbContext dbContext;

        public MinhHieuShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MinhHieuShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}