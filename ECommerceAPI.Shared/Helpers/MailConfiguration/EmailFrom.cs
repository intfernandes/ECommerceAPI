namespace ECommerceAPI.Shared.Helpers.MailConfiguration
{
    public class EmailFrom
    {
        public string? Host { get; set; }
        public int Port { get; set; }
        public bool DefaultCredentials { get; set; } 
        public string? FromAddress { get; set; }
        public string? FromName { get; set; }
        public string? Password { get; set; }
        public bool UseSSL { get; set; }
        public string? Subject { get; set; }

    }
}