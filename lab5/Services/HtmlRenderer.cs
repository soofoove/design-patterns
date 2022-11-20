namespace lab5.Services;

using System;
using lab5.Interfaces;

public class HtmlRenderer : IRenderer
{
    public void StartRendering()
    {
        //  start rendering process
        Console.WriteLine("Start HTML render");
    }

    public void StopRendering()
    {
        // stop rendering process.
        Console.WriteLine("Stop HTML render");
    }

    public void RenderString(string @string)
    {
        // render string value as html
        Console.WriteLine("Render string value into HTML");
    }

    public void RenderImage(byte[] imageBytes)
    {
        // render image as html
        Console.WriteLine("Render image into HTML");
    }
}
