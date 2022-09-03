// See https://aka.ms/new-console-template for more information

using Observer_Pattern;

var weatherStation = new WeatherStation();
var display = new Display(weatherStation);

weatherStation.Temperature = 95;
weatherStation.Temperature = 100;