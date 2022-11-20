namespace lab5.Interfaces;

public interface IRenderer
{
    void StartRendering();
    void StopRendering();
    void RenderString(string @string);
    void RenderImage(byte[] imageBytes);
}
