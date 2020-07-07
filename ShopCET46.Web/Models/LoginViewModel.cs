using System.ComponentModel.DataAnnotations;

namespace ShopCET46.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }


        [Required]
        public string Password { get; set; }


        public bool RememberMe { get; set; }

    }
}
