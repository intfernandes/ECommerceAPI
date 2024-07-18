using ECommerceAPI.Application.Interfaces.Services.Mail;
using ECommerceAPI.Shared.Helpers.MailConfiguration; 
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using MimeKit;

namespace ECommerceAPI.Infrastructure.Services.Mail
{
    public class EmailService : IEmailService
    {
        #region Properties

        private readonly EmailFrom _EmailFrom;
        private readonly ILogger<EmailService> _logger;

        #endregion Properties

        #region Constructors

        public EmailService(EmailFrom emailFrom, ILogger<EmailService> logger)
        {
            _EmailFrom = emailFrom;
            _logger = logger;
        }

        #endregion Constructors

        public async Task<bool> SendAsync(EmailTo emailTo)
        {
            try
            {
                var email = new MimeMessage();

                // Mail From
                var emailFrom = new MailboxAddress(_EmailFrom.FromName, _EmailFrom.FromAddress);
                email.From.Add(emailFrom);

                // Mail To
                var _emailTo = new MailboxAddress(emailTo.Name, emailTo.Address);
                email.To.Add(_emailTo);

                // Mail Subject
                email.Subject = emailTo.Subject;

                // Mail Body
                var mailBody = new BodyBuilder
                {
                    HtmlBody = emailTo.Body
                };
                email.Body = mailBody.ToMessageBody();

                // Mail Client
                using var smtp = new SmtpClient();

                // Bypass SSL certificate validation (for development/testing purposes only)
                smtp.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                // Connect to the SMTP server
                await smtp.ConnectAsync(_EmailFrom.Host, _EmailFrom.Port, SecureSocketOptions.StartTls);

                // Authenticate using the provided credentials
                await smtp.AuthenticateAsync(_EmailFrom.FromAddress, _EmailFrom.Password);

                // Send the email
                await smtp.SendAsync(email);

                // Disconnect from the server
                await smtp.DisconnectAsync(true);

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while sending email.");
                return false;
            }
        }
    }
}