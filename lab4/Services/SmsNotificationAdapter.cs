namespace lab4.Services;

using lab4.Interfaces;

public class SmsNotificationAdapter : INotification
{
    private readonly SmsSender _smsSender;
    private readonly string _phone;

    public SmsNotificationAdapter(SmsSender smsSender, string phone)
    {
        _smsSender = smsSender;
        _phone = phone;
    }

    public void Send(string title, string message)
    {
        _smsSender.Send(_phone, title, message);
    }
}
