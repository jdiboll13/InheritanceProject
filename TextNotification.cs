using System;

namespace InheritanceProject
{
    public class TextNotification : Notifications
    {
        public string Recipient { get; set; }
        public string SmsProvider { get; set; }
        public TextNotification(string subject, string body, string recipient, string smsProvider) : base(subject, body)
        {
            Subject = subject;
            Body = body;
            Recipient = recipient;
            SmsProvider = smsProvider;
        }
        public override void Transport()
        {
            try
            {
                Console.WriteLine(value: $"You have received a {SmsProvider} text message. The subject is: {Subject} Dear {Recipient}, {Body}");
            }
            catch (NoTransportException)
            {
                throw;
            }
        }
    }
}
