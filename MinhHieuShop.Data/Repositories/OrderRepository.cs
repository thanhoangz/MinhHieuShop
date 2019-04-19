using MinhHieuShop.Data.Infrastructure;
using MinhHieuShop.Model.Models;

namespace MinhHieuShop.Data.Repositories
{
    public interface IOrderRepository  : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}