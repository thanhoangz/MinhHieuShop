namespace MinhHieuShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        MinhHieuShopDbContext dbContext;
        public MinhHieuShopDbContext Init()
        {
            return dbContext ?? (dbContext = new MinhHieuShopDbContext()); //nếu db == null thì khởi tạo
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
