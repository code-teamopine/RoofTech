using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RoofTech.Models;
using RoofTech.Services;

namespace RoofTech.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _env;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        public HomeController(IHostingEnvironment env, IEmailService emailService, IConfiguration configuration)
        {
            _env = env;
            this._emailService = emailService;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Inquiry(EmailModel model)
        {
            try
            {
                //_logger.LogInformation("Line No. 48");
                var emailTemplateFilePath = System.IO.Path.Join(_env.WebRootPath, @"\templates\EmailTemplate.html");
                var message = System.IO.File.ReadAllText(emailTemplateFilePath);
                //_logger.LogInformation("Line No. 51");
                message = message.Replace("{{Name}}", model.Name);
                message = message.Replace("{{Email}}", model.Email);
                message = message.Replace("{{Phone}}", model.Phone);
                message = message.Replace("{{City}}", model.City);
                message = message.Replace("{{Product Offering}}", model.ProductOffering);
                message = message.Replace("{{Message}}", model.Message);
                //_logger.LogInformation("Line No. 56");
                await _emailService.SendEmail(_configuration["Email:ToEmail"].ToString(), "New Inquiry", message);
                //_logger.LogInformation("Line No. 58");
                if (model.IsDownloadBrochure == false)
                {
                    return View("ThankYou");
                }
                else
                {
                    return await Download("RoofTechBrochure.pdf");
                }
            }
            catch (Exception ex)
            {
                //_logger.LogInformation(ex.Message + Environment.NewLine + ex.StackTrace);
                throw ex;
            }
        }

        public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename not present");

            var path = _env.WebRootPath + @"\\pdfs\\" + filename;

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
