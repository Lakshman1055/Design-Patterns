namespace Strategy_Pattern;

public class SimpleFlyStrategy : IFlyStrategy
{
    public string Fly()
    {
        return "I use simple fly method";
    }
}