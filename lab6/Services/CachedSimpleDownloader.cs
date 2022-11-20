namespace lab6.Services;

using System;
using System.Collections.Generic;
using lab6.Interfaces;
using lab6.Models;

public class CachedSimpleDownloader : IDownloader
{
    private readonly IDownloader _downloader;
    private readonly Dictionary<string, File> _cache = new();

    public CachedSimpleDownloader(IDownloader downloader)
    {
        _downloader = downloader;
    }

    public File Download(string fileName)
    {
        if (_cache.TryGetValue(fileName, out File cachedFile))
        {
            Console.WriteLine("File has been already downloaded");
            return cachedFile;
        }

        Console.WriteLine("File has not been cached yet");
        File downloadedFile = _downloader.Download(fileName);
        _cache[fileName] = downloadedFile;

        return downloadedFile;
    }
}
