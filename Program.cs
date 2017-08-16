using System;

namespace InheritanceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailNotification
            (
                subject:"What up?",
                body:"What's Cracking? Let's hang this weekend.",
                recipient:"Foxy Lady",
                smtpProvider:"Gmail"
            );
            var text = new TextNotification
            (
                subject:"Why is there a subject to a text?",
                body:"Wyd?",
                recipient:"Foxy Lady",
                smsProvider:"- Sent from my iPhone"
            );
            email.Transport();
            text.Transport();
        }
    }
}
