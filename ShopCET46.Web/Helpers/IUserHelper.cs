using Microsoft.AspNetCore.Identity;
using ShopCET46.Web.Data.Entities;
using ShopCET46.Web.Models;
using System.Threading.Tasks;

namespace ShopCET46.Web.Helpers
{
    public interface IUserHelper
    {

        Task<User> GetUserByEmailAsync(string email);


        Task<IdentityResult> AddUserAsync(User user, string password);


        Task<SignInResult> LoginAsync(LoginViewModel model);


        Task LogoutAsync();


        Task<IdentityResult> UpdateUserAsync(User user);


        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);


        Task<SignInResult> ValidatePasswordAsync(User user, string password);


        Task CheckRoleAsync(string roleName);


        Task<bool> IsUserInRoleAsync(User user, string roleName);


        Task AddUsertoRoleAsync(User user, string roleName);


        Task<string> GenerateEmailConfirmationTokenAsync(User user);


        Task<IdentityResult> ConfirmEmailAsync(User user, string token);


        Task<User> GetUserByIdAsync(string userId);



        Task<string> GeneratePasswordResetTokenAsync(User user);


        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);
    }
}
