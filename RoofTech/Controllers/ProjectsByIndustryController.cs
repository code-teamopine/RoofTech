using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RoofTech.Models;
using RoofTech.Services;

namespace RoofTech.Controllers
{
    public class ProjectsByIndustryController : Controller
    {
        private IHostingEnvironment _env;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        //private readonly ILogger<ContactUsController> _logger;

        public ProjectsByIndustryController(IHostingEnvironment env, IConfiguration configuration, IEmailService emailService)
        //, ILogger<ContactUsController> logger)
        {
            _env = env;
            this._emailService = emailService;
            _configuration = configuration;
            //_logger = logger;
        }

        public IActionResult Index()
        {
            //_logger.LogInformation("I am at ContactUs");
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public async Task<IActionResult> SendEmail(EmailModel model)
        //{
        //    try
        //    {
        //        //_logger.LogInformation("Line No. 48");
        //        var emailTemplateFilePath = System.IO.Path.Join(_env.WebRootPath, @"\templates\EmailTemplate.html");
        //        var message = System.IO.File.ReadAllText(emailTemplateFilePath);
        //        //_logger.LogInformation("Line No. 51");
        //        message = message.Replace("{{Name}}", model.Name);
        //        message = message.Replace("{{Email}}", model.Email);
        //        message = message.Replace("{{Phone}}", model.Phone);
        //        message = message.Replace("{{Message}}", model.Message);
        //        //_logger.LogInformation("Line No. 56");
        //        await _emailService.SendEmail(_configuration["Email:ToEmail"].ToString(), "New Inquiry", message);
        //        //_logger.LogInformation("Line No. 58");
        //        return View("ThankYou");
        //    }
        //    catch(Exception ex)
        //    {
        //        //_logger.LogInformation(ex.Message + Environment.NewLine + ex.StackTrace);
        //        throw ex;
        //    }
        //}
    }
}
