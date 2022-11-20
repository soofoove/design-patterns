namespace lab5;

using System;
using System.Security.Cryptography;
using lab5.Models;
using lab5.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        // Simple page
        var simplePage = new SimplePage(new JsonRenderer())
        {
            Title = "Simple page title",
            Content = "Simple page content"
        };

        simplePage.Render();

        simplePage.Renderer = new HtmlRenderer();
        simplePage.Render();

        // Product page
        var productPage = new ProductPage(new XmlRenderer())
        {
            Product = new Product
            {
                Id = Guid.NewGuid(),
                Title = "Product title",
                Description = "Product description",
                ImageBytes = RandomNumberGenerator.GetBytes(50)
            }
        };

        productPage.Render();

        productPage.Renderer = new JsonRenderer();
        productPage.Render();
    }
}
