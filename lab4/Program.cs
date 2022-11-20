namespace lab4;

using lab4.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        var emailNotification = new EmailNotification("admin@mail.com");
        emailNotification.Send("Email Title", "Email Message");

        var slackSender = new SlackSender("login123", "52c8ea3d-0712-414a-b3a0-7b31740aaaa3");
        var slackNotification = new SlackNotificationAdapter(slackSender, "chatId123");
        slackNotification.Send("Slack Title", "Slack Message");

        var smsSender = new SmsSender("SmsSender");
        var smsNotification = new SmsNotificationAdapter(smsSender, "+3805555555");
        smsNotification.Send("SMS Title", "SMS Message");
    }
}
