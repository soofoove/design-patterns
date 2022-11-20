namespace lab5;

using lab5.Interfaces;
using lab5.Models;

public class ProductPage : AbstractPage
{
    public Product Product { get; set; }

    public ProductPage(IRenderer renderer)
        : base(renderer)
    {
    }

    public override void Render()
    {
        _renderer.StartRendering();
        _renderer.RenderString(Product.Id.ToString());
        _renderer.RenderString(Product.Title);
        _renderer.RenderString(Product.Description);
        _renderer.RenderImage(Product.ImageBytes);
        _renderer.StopRendering();
    }
}
