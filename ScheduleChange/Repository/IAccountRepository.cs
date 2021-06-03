using Microsoft.AspNetCore.Identity;
using ScheduleChange.Models;
using System.Threading.Tasks;

namespace ScheduleChange.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOutAsync();
    }
}