namespace lab3.Models;

using lab3.Interfaces;

public class FacebookCredentials : ICredentials
{
    public string Login { get; set; }
    public string Password { get; set; }
}
