using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using ScheduleChange.Models;
using ScheduleChange.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleChange.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;
        public AccountRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUserService userService,
            IEmailService emailService,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _emailService = emailService;
            _configuration = configuration;
        }

        public async Task<IdentityResult> CreateUserAsync(SignUpUser userModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Email = userModel.Email,
                UserName = userModel.Email

            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                if (!string.IsNullOrEmpty(token))
                {
                    await SendEmailConfirmationEmail(user, token);
                }
            }
            return result;
        }
        public async Task<IdentityResult> ConfirmEmailAsync(string uid, string token)
        {
            return await _userManager.ConfirmEmailAsync(await _userManager.FindByIdAsync(uid), token);
        }
        public async Task<SignInResult> PasswordSignInAsync(SignInModel signInModel)
        {
            return await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, signInModel.RememberMe, false);
        }
        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        private async Task SendEmailConfirmationEmail(ApplicationUser user, string token)
        {
            string appDomain = _configuration.GetSection("Application:AppDomain").Value;
            string confirmationLink = _configuration.GetSection("Application:EmailConfirmation").Value;

            UserEmailOptions options = new UserEmailOptions
            {
                ToEmails = new List<string>() { user.Email },
                PlaceHolders = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("{{UserName}}", user.FirstName),
                    new KeyValuePair<string, string>("{{Link}}",
                        string.Format(appDomain + confirmationLink, user.Id, token))
                }
            };

            await _emailService.SendEmailForEmailConfirmation(options);
        }
    }
}
