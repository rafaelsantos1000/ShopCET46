using Microsoft.AspNetCore.Http;
using ShopCET46.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace ShopCET46.Web.Models
{
    public class ProductViewModel : Product
    {

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
