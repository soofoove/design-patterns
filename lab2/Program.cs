namespace lab2;

public static class Program
{
    public static void Main(string[] args)
    {
        User user1 = new User
        {
            FirstName = "John",
            LastName = "Doe",
            FileStorage = AmazonS3FileStorage.CreateInstance()
        };

        User user2 = new User
        {
            FirstName = "Jay",
            LastName = "Brown",
            FileStorage = LocalFileStorage.CreateInstance()
        };
    }
}
