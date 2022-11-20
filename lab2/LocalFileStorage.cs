namespace lab2;

using System;
using lab2.Interfaces;

public class LocalFileStorage : SingletonBase<LocalFileStorage>, IFileStorage
{
    public LocalFileStorage()
    {
        Console.WriteLine($"{nameof(LocalFileStorage)} ctor");
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
