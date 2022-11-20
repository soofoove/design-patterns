namespace lab5.Services;

using System;
using lab5.Interfaces;

public class JsonRenderer : IRenderer
{
    public void StartRendering()
    {
        //  start rendering process
        Console.WriteLine("Start JSON render");
    }

    public void StopRendering()
    {
        // stop rendering process.
        Console.WriteLine("Stop JSON render");
    }

    public void RenderString(string @string)
    {
        // render string as json field
        Console.WriteLine("Render string value into JSON");
    }

    public void RenderImage(byte[] imageBytes)
    {
        // render image as base64-string json field (for example)
        Console.WriteLine("Render image into JSON");
    }
}
