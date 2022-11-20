namespace lab3.Services;

using lab3.Interfaces;
using lab3.Models;

public class LinkedInCreator : ISocialNetworkCreator<LinkedInCredentials>
{
    public ISocialNetwork Create(LinkedInCredentials credentials)
    {
        // setup connection using credentials
        return new LinkedIn();
    }
}
