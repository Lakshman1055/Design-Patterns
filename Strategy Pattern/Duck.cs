namespace Strategy_Pattern;

public class Duck
{
    public string Name { get; set; } = string.Empty;

    private IFlyStrategy _flyStrategy;

    public Duck(string name, IFlyStrategy flyStrategy)
    {
        Name = name;
        _flyStrategy = flyStrategy;
    }

    public string Fly()
    {
        return _flyStrategy.Fly();
    }
}