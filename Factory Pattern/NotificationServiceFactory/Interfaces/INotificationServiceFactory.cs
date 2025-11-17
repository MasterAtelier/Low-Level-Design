using NotificationFactory.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationFactory.Interfaces
{
    public interface INotificationServiceFactory
    {
        INotificationService CreateNotificationService(NotificationType type);
    }
}
