using System;

namespace InheritanceProject
{
    public abstract class Notifications
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string Subject { get; set; }
        public string Body { get; set; }

        public Notifications(string subject, string body)
        {
            this.Subject = subject;
            this.Body = body;
        }
        public abstract void Transport();

    }
}
