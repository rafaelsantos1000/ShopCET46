using ShopCET46.Web.Data.Entities;

namespace ShopCET46.Web.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }
    }
}
