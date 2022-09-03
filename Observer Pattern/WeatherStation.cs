namespace Observer_Pattern;

public class WeatherStation : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();

    private double _temperature;

    public double Temperature
    {
        get
        {
            return _temperature;
        }
        set
        {
            _temperature = value;
            Notify();
        }
    }

    public void AddObserver(IObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        if (_observers.Contains(observer))
        {
            _observers.Remove(observer);
        }
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}