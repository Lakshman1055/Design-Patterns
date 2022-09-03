// See https://aka.ms/new-console-template for more information

using Strategy_Pattern;

var duck1 = new Duck("Donald", new JetFlyStrategy());
Console.WriteLine($"This is {duck1.Name} duck and {duck1.Fly()}");

var duck2 = new Duck("Daisy", new SimpleFlyStrategy());
Console.WriteLine($"This is {duck2.Name} duck and {duck2.Fly()}");
