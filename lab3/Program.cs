namespace lab3;

using lab3.Interfaces;
using lab3.Models;
using lab3.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        // Facebook
        var facebookCredentials = new FacebookCredentials
        {
            Login = "login",
            Password = "password"
        };

        var facebookCreator = new FacebookCreator();
        ISocialNetwork facebook = facebookCreator.Create(facebookCredentials);

        facebook.PublishPost(new Post
        {
            Text = "test Facebook message"
        });

        // LinkedIn
        var linkedInCredentials = new LinkedInCredentials
        {
            Email = "test@email.com",
            Password = "password"
        };

        var linkedInCreator = new LinkedInCreator();
        ISocialNetwork linkedIn = linkedInCreator.Create(linkedInCredentials);

        linkedIn.PublishPost(new Post
        {
            Text = "test LinkedIn message"
        });
    }
}
