using OOP_4.Interfaces;

namespace OOP_4.Classes
{
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending push notification to {recipient}: {message}");
        }
    }

}
