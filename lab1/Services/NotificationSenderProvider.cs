namespace lab1.Services;

using lab1.Interfaces;
using lab1.Models.Enums;

public class NotificationSenderProvider
{
    public INotificationSender DefaultSender { get; set; }

    public void SetDefaultSender(NotificationSenderTypes senderType)
    {
        // sets default sender.
    }

    public INotificationSender GetSender(NotificationSenderTypes senderType)
    {
        // returns sender by its sender type. if not found - returns default sender.
        return null;
    }

    public void AddSender(INotificationSender sender)
    {
        // adds available sender.
    }

    public void RemoveSender(NotificationSenderTypes senderType)
    {
        // removes sender.
    }
}
