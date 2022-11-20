﻿namespace lab1.Services;

using System;
using lab1.Interfaces;
using lab1.Models;
using lab1.Models.Enums;

public class MessengerNotificationSender : INotificationSender
{
    public NotificationSenderTypes SenderType => NotificationSenderTypes.Messenger;

    public void SendNotification(User recipient, Notification notification)
    {
        Console.WriteLine("Sends messenger notification");
    }
}
