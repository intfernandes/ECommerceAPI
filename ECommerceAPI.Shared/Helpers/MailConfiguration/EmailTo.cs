namespace ECommerceAPI.Shared.Helpers.MailConfiguration
{
    public class EmailTo
    {
        #region Properties

        public string Name { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        #endregion Properties

        #region Constructors

        public EmailTo(string toName, string toAddress, string subject, string body)
        {
            Name = toName;
            Address = toAddress;
            Subject = subject;
            Body = body;
        }

        #endregion Constructors
    }
}