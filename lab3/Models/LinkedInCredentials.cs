namespace lab3.Models;

using lab3.Interfaces;

public class LinkedInCredentials : ICredentials
{
    public string Email { get; set; }
    public string Password { get; set; }
}
