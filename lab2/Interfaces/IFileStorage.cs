namespace lab2.Interfaces;

public interface IFileStorage
{
    void Write(string fileName, byte[] bytes);
    byte[] Read(string fileName);
}
