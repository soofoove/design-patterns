namespace lab4.Services;

using System;

public class SlackSender
{
    private readonly string _apiKey;
    private readonly string _login;

    public SlackSender(string login, string apiKey)
    {
        _login = login;
        _apiKey = apiKey;
    }

    public void Send(string chatId, string title, string message)
    {
        Console.WriteLine($"Authorized with API key {_apiKey} and login {_login}");
        Console.WriteLine($"Sent Slack message to chat {chatId} with title {title} that says {message}");
    }
}
