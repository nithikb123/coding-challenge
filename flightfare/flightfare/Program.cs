using flightfare;

var f = new flight();
{
    Console.WriteLine("Enter the time:");
    f.Time =int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the fare:");
    f.Fare = int.Parse(Console.ReadLine());
}

Console.WriteLine(f.Fare);
