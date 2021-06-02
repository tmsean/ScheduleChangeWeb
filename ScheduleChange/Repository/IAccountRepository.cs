using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using ScheduleChange.Models;

namespace ScheduleChange.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUser userModel);
    }
}