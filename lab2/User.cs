namespace lab2;

using lab2.Interfaces;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IFileStorage FileStorage { get; set; }
}
