using ECommerceAPI.Application.Interfaces.Services.Mail;
using ECommerceAPI.Infrastructure.Services.Mail;
using ECommerceAPI.Shared.Helpers.MailConfiguration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ECommerceAPI.Infrastructure.Extensions.Mail
{
    public static class MailServiceCollection
    {
        public static IServiceCollection AddMailService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailFrom>(configuration.GetSection("EmailConfiguration"));
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<EmailFrom>>().Value);

            services.AddScoped(typeof(IEmailService), typeof(EmailService));
            return services;
        }
    }
}