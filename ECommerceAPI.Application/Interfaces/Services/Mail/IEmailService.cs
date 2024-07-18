


using ECommerceAPI.Shared.Helpers.MailConfiguration;

namespace ECommerceAPI.Application.Interfaces.Services.Mail
{
    public interface IEmailService
    {
        Task<bool> SendAsync(EmailTo mailData);
    }
}