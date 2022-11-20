namespace lab1.Interfaces;

using lab1.Models;
using lab1.Models.Enums;

public interface INotificationSender
{
    public NotificationSenderTypes SenderType { get; }
    void SendNotification(User recipient, Notification notification);
}
