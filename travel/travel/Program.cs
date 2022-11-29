using travel;

var p = new Fp();
Console.WriteLine("enter name and miles travelled");
Console.WriteLine("name:");
p.name = Console.ReadLine();
Console.WriteLine("miles:");
p.Miles=int.Parse(Console.ReadLine());
p.Points = 0;
Console.WriteLine($"The frequent flyer point is {p.Points}");

