using MinhHieuShop.Data.Infrastructure;
using MinhHieuShop.Model.Models;

namespace MinhHieuShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}