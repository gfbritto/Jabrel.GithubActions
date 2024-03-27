//write a simple program which the user can make actions with car class

using Jabrel.GithubActions.Domain;

var car = new Car();

Console.WriteLine("What do you want to do with the car?");
Console.WriteLine("1. Drive");
Console.WriteLine("2. Stop");
Console.WriteLine("3. Refuel");
Console.WriteLine("4. Turn on");

var action = Console.ReadLine();

Console.WriteLine( "nossa nova feature");
switch (action)
{
    case "1":
        car.Drive();
        break;
    case "2":
        car.Stop();
        break;
    case "3":
        car.Refuel();
        break;
    case "4":
        car.TurnOn();
        break;
    default:
        Console.WriteLine("Invalid action");
        break;
}

Console.WriteLine("Press any key to exit");
