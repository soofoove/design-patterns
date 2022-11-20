namespace lab3.Services;

using System;
using lab3.Interfaces;
using lab3.Models;

public class Facebook : ISocialNetwork
{
    public void PublishPost(Post post)
    {
        Console.WriteLine($"Posting message in Facebook. Message: {post.Text}");
    }
}
