namespace lab5.Services;

using System;
using lab5.Interfaces;

public class XmlRenderer : IRenderer
{
    public void StartRendering()
    {
        //  start rendering process
        Console.WriteLine("Start XML render");
    }

    public void StopRendering()
    {
        // stop rendering process.
        Console.WriteLine("Stop XML render");
    }

    public void RenderString(string @string)
    {
        // render string as xml node
        Console.WriteLine("Render string value into XML");
    }

    public void RenderImage(byte[] imageBytes)
    {
        // render image as base64-string xml node (for example)
        Console.WriteLine("Render image into XML");
    }
}
