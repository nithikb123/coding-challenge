DateTime Dob;
Console.WriteLine("Enter dob of passenger");
Dob = DateTime.Parse ((Console.ReadLine()));

int age = (int)((DateTime.Now - Dob).TotalDays/365.242199);
Console.WriteLine($" The age in years is {age}");
double days = ((DateTime.Now - Dob).TotalDays);
Console.WriteLine($"The age in days is {days}");
double month = days / 30.41;
Console.WriteLine($"The age in month is {month}");
double hours = days * 24;
Console.WriteLine($"The age in hours is {hours}");
double minutes = hours * 60;
Console.WriteLine($"The age in hours is {minutes}");
double seconds = minutes * 60;
Console.WriteLine($"The age in minutes is {seconds}");

if(Dob.Year%4==0)
{
    Console.WriteLine("The person was born in leap year");
}
