namespace lab3.Services;

using lab3.Interfaces;
using lab3.Models;

public class FacebookCreator : ISocialNetworkCreator<FacebookCredentials>
{
    public ISocialNetwork Create(FacebookCredentials credentials)
    {
        // setup connection using credentials
        return new Facebook();
    }
}
