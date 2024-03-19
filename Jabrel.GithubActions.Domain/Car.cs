namespace Jabrel.GithubActions.Domain;

using Jabrel.GithubActions.Domain.Interfaces;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving car");
    }

    public void Refuel()
    {
        Console.WriteLine("Refueling car");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping car");
        Console.BackgroundColor = ConsoleColor.Red;
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on car");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
    }
}
