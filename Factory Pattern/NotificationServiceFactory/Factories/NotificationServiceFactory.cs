using NotificationFactory.Enums;
using NotificationFactory.Interfaces;
using NotificationFactory.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationFactory.Factories
{
    public class NotificationServiceFactory : INotificationServiceFactory
    {
        
        public INotificationService CreateNotificationService(NotificationType notificationType)
        {
            return notificationType switch
            {
                NotificationType.Email => new EmailNotificationService(),
                NotificationType.Sms => new SmsNotificationService(),
                NotificationType.Push => new PushNotificationService(),
                _ => throw new NotSupportedException(),
            };

        }
    }
}
