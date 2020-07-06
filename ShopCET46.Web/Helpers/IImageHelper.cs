using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ShopCET46.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string folder);
    }
}
