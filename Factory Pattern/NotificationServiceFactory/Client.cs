using NotificationFactory.Enums;
using NotificationFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationFactory
{
    public class Client
    {
        public readonly INotificationService notificationService;
        public Client(INotificationServiceFactory notificationServiceFactory, NotificationType notificationType) {
            notificationService = notificationServiceFactory.CreateNotificationService(notificationType);
        }
        public void Send(string to, string message)
        {
            notificationService.SendNotification(to, message);
        }
    }
}
