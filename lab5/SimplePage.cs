namespace lab5;

using lab5.Interfaces;

public class SimplePage : AbstractPage
{
    public string Title { get; set; }
    public string Content { get; set; }

    public SimplePage(IRenderer renderer)
        : base(renderer)
    {
    }

    public override void Render()
    {
        _renderer.StartRendering();
        _renderer.RenderString(Title);
        _renderer.RenderString(Content);
        _renderer.StopRendering();
    }
}
