using Microsoft.AspNetCore.Identity;
using ScheduleChange.Models;
using System.Threading.Tasks;

namespace ScheduleChange.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task GenerateEmailConfirmationTokenAsync(ApplicationUser user);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOutAsync();
        Task<ApplicationUser> GetUserByEmailAsync(string email);
    }
}