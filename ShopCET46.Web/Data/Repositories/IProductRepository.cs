using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCET46.Web.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ShopCET46.Web.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();


        IEnumerable<SelectListItem> GetComboProducts();
    }
}
