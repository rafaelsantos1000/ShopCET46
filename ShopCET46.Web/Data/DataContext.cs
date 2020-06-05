using Microsoft.EntityFrameworkCore;
using ShopCET46.Web.Data.Entities;

namespace ShopCET46.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
