using NotificationFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationFactory.Services
{
    public class EmailNotificationService : INotificationService
    {

        public EmailNotificationService() {

        }
        public void SendNotification(string email, string message)
        {
            Console.WriteLine($"Email Notification Sent to {email} with message {message}");
        }
    }
}
