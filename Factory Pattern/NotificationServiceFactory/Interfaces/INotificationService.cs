using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationFactory.Interfaces
{
    public interface INotificationService
    {
        void SendNotification(string to, string message);
    }
}
