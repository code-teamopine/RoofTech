using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace RoofTech.Services
{
    public interface IEmailService
    {
        Task SendEmail(string to, string subject, string message);
    }
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmail(string to, string subject, string message)
        {
            try
            {
                using (var client = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = _configuration["Email:FromEmail"],
                        Password = _configuration["Email:Password"]
                    };

                    client.Credentials = credential;
                    client.Host = _configuration["Email:Host"];
                    client.Port = int.Parse(_configuration["Email:Port"]);
                    client.EnableSsl = bool.Parse(_configuration["Email:EnableSsl"]);
                    
                    using (var emailMessage = new MailMessage())
                    {
                        emailMessage.To.Add(new MailAddress(to));
                        emailMessage.From = new MailAddress(_configuration["Email:FromEmail"]);
                        emailMessage.Subject = subject;
                        emailMessage.Body = message;
                        emailMessage.IsBodyHtml = true;
                        client.Send(emailMessage);
                    }
                }
                await Task.CompletedTask;
            }
            catch(Exception ex)
            {
                var j = ex;
            }
        }
    }
}