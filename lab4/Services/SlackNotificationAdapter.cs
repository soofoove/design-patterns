namespace lab4.Services;

using lab4.Interfaces;

public class SlackNotificationAdapter : INotification
{
    private readonly SlackSender _slackSender;
    private readonly string _chatId;

    public SlackNotificationAdapter(SlackSender slackSender, string chatId)
    {
        _slackSender = slackSender;
        _chatId = chatId;
    }

    public void Send(string title, string message)
    {
        _slackSender.Send(_chatId, title, message);
    }
}
