namespace lab5;

using lab5.Interfaces;

public abstract class AbstractPage
{
    protected IRenderer _renderer;

    public IRenderer Renderer
    {
        set { _renderer = value; }
    }

    public AbstractPage(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public abstract void Render();
}
