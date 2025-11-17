using NotificationFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationFactory.Services
{
    public class SmsNotificationService : INotificationService
    {

        public SmsNotificationService() {

        }
        public void SendNotification(string mobileNumber, string message)
        {
            Console.WriteLine($"Sms Notification Sent to mobile number {mobileNumber} and message to {message}");
        }
    }
}
