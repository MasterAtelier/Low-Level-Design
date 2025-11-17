using NotificationFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationFactory.Services
{
    public class PushNotificationService : INotificationService
    {

        public PushNotificationService() {

        }
        public void SendNotification(string deviceToken, string message)
        {
            Console.WriteLine($"Push Notification Sent to device {deviceToken} and {message}");
        }
    }
}
