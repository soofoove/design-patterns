namespace lab5.Models;

using System;

public class Product
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public byte[] ImageBytes { get; set; }
}
