using NotificationFactory;
using NotificationFactory.Enums;
using NotificationFactory.Factories;

var factory = new NotificationServiceFactory();

var emailClient = new Client(factory, NotificationType.Email);
emailClient.Send("test@gmail.com", "Email Test Message");

var smsClient = new Client(factory, NotificationType.Sms);
smsClient.Send("9876543210", "SMS Test Message");

var pushClient = new Client(factory, NotificationType.Push);
pushClient.Send("device_token_001", "Push Test Message");
