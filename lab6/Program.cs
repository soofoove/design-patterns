namespace lab6;

using lab6.Interfaces;
using lab6.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        IDownloader cachedDownloader = new CachedSimpleDownloader(new SimpleDownloader());

        cachedDownloader.Download("some-file");
        cachedDownloader.Download("some-file");
    }
}
