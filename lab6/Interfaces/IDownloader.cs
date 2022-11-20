namespace lab6.Interfaces;

using lab6.Models;

public interface IDownloader
{
    File Download(string fileName);
}
