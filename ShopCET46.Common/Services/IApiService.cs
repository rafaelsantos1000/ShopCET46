using ShopCET46.Common.Models;
using System.Threading.Tasks;

namespace ShopCET46.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
    }
}
