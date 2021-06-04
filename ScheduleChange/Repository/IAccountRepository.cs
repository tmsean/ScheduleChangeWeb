using Microsoft.AspNetCore.Identity;
using ScheduleChange.Models;
using System.Threading.Tasks;

namespace ScheduleChange.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
        Task<IdentityResult> CreateUserAsync(SignUpUser userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOutAsync();
    }
}