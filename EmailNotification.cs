using System;

namespace InheritanceProject
{
    public class EmailNotification : Notifications
    {
        public string Recipient { get; set; }
        public string SmtpProvider { get; set; }
        public EmailNotification(string subject, string body, string recipient, string smtpProvider) : base(subject, body)
        {
            Subject = subject;
            Body = body;
            Recipient = recipient;
            SmtpProvider = smtpProvider;
        }
        public override void Transport()
        {
            try
            {
                Console.WriteLine($"You have a {SmtpProvider} message. The subject is: {Subject} Dear {Recipient}, {Body}");
            }
            catch (NoTransportException)
            {
                throw;
            }
        }
    }
}
