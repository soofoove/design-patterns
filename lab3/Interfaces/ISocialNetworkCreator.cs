namespace lab3.Interfaces;

public interface ISocialNetworkCreator<in T> where T : class, ICredentials
{
    ISocialNetwork Create(T credentials);
}
