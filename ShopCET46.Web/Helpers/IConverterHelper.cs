using ShopCET46.Web.Data.Entities;
using ShopCET46.Web.Models;

namespace ShopCET46.Web.Helpers
{
    public interface IConverterHelper
    {

        Product ToProduct(ProductViewModel model, string path, bool isNew);



        ProductViewModel ToProductViewModel(Product model);
    }
}
