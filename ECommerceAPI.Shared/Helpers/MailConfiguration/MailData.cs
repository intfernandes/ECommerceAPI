namespace ECommerceAPI.Shared.Helpers.MailConfiguration
{
    public class MailData
    {
        #region Properties

        public string MailToName { get; set; }
        public string MailToAddress { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }

        #endregion Properties

        #region Constructors

        public MailData(string mailToName, string mailToAddress, string mailSubject, string mailBody)
        {
            MailToName = mailToName;
            MailToAddress = mailToAddress;
            MailSubject = mailSubject;
            MailBody = mailBody;
        }

        #endregion Constructors
    }
}