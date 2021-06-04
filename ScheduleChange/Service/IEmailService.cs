using ScheduleChange.Models;
using System.Threading.Tasks;

namespace ScheduleChange.Service
{
    public interface IEmailService
    {
        Task SendEmailForEmailConfirmation(UserEmailOptions userEmailOptions);
    }
}