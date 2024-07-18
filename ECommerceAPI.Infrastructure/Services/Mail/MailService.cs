﻿using ECommerceAPI.Application.Interfaces.Services.Mail;
using ECommerceAPI.Shared.Helpers.MailConfiguration;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using MimeKit;

namespace ECommerceAPI.Infrastructure.Services.Mail
{
    public class MailService : IMailService
    {
        #region Properties

        private readonly MailConfiguration _mailConfiguration;
        private readonly ILogger<MailService> _logger;

        #endregion Properties

        #region Constructors

        public MailService(MailConfiguration mailConfiguration, ILogger<MailService> logger)
        {
            _mailConfiguration = mailConfiguration;
            _logger = logger;
        }

        #endregion Constructors

        public async Task<bool> SendAsync(MailData mailData)
        {
            try
            {
                var mailMessage = new MimeMessage();

                // Mail From
                var mailFrom = new MailboxAddress(_mailConfiguration.Name, _mailConfiguration.Address);
                mailMessage.From.Add(mailFrom);

                // Mail To
                var mailTo = new MailboxAddress(mailData.MailToName, mailData.MailToAddress);
                mailMessage.To.Add(mailTo);

                // Mail Subject
                mailMessage.Subject = mailData.MailSubject;

                // Mail Body
                var mailBody = new BodyBuilder
                {
                    HtmlBody = mailData.MailBody
                };
                mailMessage.Body = mailBody.ToMessageBody();

                // Mail Client
                using var mailClient = new SmtpClient();

                // Bypass SSL certificate validation (for development/testing purposes only)
                mailClient.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                // Connect to the SMTP server
                await mailClient.ConnectAsync(_mailConfiguration.Host, _mailConfiguration.Port, SecureSocketOptions.StartTls);

                // Authenticate using the provided credentials
                await mailClient.AuthenticateAsync(_mailConfiguration.UserName, _mailConfiguration.Password);

                // Send the email
                await mailClient.SendAsync(mailMessage);

                // Disconnect from the server
                await mailClient.DisconnectAsync(true);

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