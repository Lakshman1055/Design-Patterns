namespace Observer_Pattern;

public class Display : IObserver
{
    private WeatherStation _weatherStation;
    
    public Display(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;
        _weatherStation.AddObserver(this);
    }
    public void Update()
    {
        Console.WriteLine("The update method for the " +
                          "display has been called and " +
                          "the temperature changed to " +
                          $"{_weatherStation.Temperature}");
    }
}