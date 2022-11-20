namespace lab3.Services;

using System;
using lab3.Interfaces;
using lab3.Models;

public class LinkedIn : ISocialNetwork
{
    public void PublishPost(Post post)
    {
        Console.WriteLine($"Posting message in LinkedIn. Message: {post.Text}");
    }
}
