namespace lab2;

using System;
using lab2.Interfaces;

public class AmazonS3FileStorage : SingletonBase<AmazonS3FileStorage>, IFileStorage
{
    public AmazonS3FileStorage()
    {
        Console.WriteLine($"{nameof(AmazonS3FileStorage)} ctor");
    }

    public void Write(string fileName, byte[] bytes)
    {
        throw new System.NotImplementedException();
    }

    public byte[] Read(string fileName)
    {
        throw new System.NotImplementedException();
    }
}
