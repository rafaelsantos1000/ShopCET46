using ShopCET46.Web.Data.Entities;
using System.Linq;

namespace ShopCET46.Web.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }
}
