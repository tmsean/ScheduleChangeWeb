using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScheduleChange.Models;
using ScheduleChange.Service;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ScheduleChange.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        public HomeController(ILogger<HomeController> logger, IUserService userService,
            IEmailService emailService)
        {
            _logger = logger;
            _userService = userService;
            _emailService = emailService;
        }
        [Route("~/")]
        public async Task<IActionResult> Index()
        {
            //UserEmailOptions options = new UserEmailOptions
            //{
            //    ToEmails = new List<string>() { "fe2893c82f-7dfd76@inbox.mailtrap.io" },
            //    PlaceHolders = new List<KeyValuePair<string, string>>()
            //    {
            //        new KeyValuePair<string, string>("{{UserName}}", "John")
            //    }
            //};
            //await _emailService.SendTestEmail(options);
            return View();
        }
        // Uncomment the below line to enable roles on this action method.
        //[Authorize(Roles = "Admin,User")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
