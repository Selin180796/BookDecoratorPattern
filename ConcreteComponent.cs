
public class ConcreteComponent : IComponent<string>
{
    private string title;

    public ConcreteComponent(string title)
    {
        this.title = title;
    }

    public string GetText()
    {
        return title;
    }
}
