using ShopCET46.Web.Data.Entities;
using ShopCET46.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCET46.Web.Data.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrdersAsync(string userName);


        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string userName);


        Task AddItemToOrderAsync(AddItemViewModel model, string userName);


        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);


        Task DeleteDetailTempAsync(int id);


        Task<bool> ConfirmOrderAsync(string userName);


        Task DeliverOrderAsync(DeliverViewModel model);


        Task<Order> GetOrderAsync(int id);
    }
}
