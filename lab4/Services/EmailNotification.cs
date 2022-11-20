namespace lab4.Services;

using System;
using lab4.Interfaces;

public class EmailNotification : INotification
{
    private readonly string _adminEmail;

    public EmailNotification(string adminEmail)
    {
        _adminEmail = adminEmail;
    }

    public void Send(string title, string message)
    {
        Console.WriteLine($"Sent email with title {title} to {_adminEmail} that says {message}.");
    }
}
