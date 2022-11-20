namespace lab6.Services;

using System;
using System.Security.Cryptography;
using lab6.Interfaces;
using lab6.Models;

public class SimpleDownloader : IDownloader
{
    public File Download(string fileName)
    {
        // download file from remote server
        Console.WriteLine("Downloading from remote server");
        return new File
        {
            FileName = fileName,
            Content = RandomNumberGenerator.GetBytes(50)
        };
    }
}
