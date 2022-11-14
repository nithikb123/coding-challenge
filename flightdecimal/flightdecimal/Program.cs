var flight = new float[5];
float a;
Console.WriteLine("Enter flight fare:");
for (int i = 0; i < flight.Length; i++)
{
    flight[i] = float.Parse(Console.ReadLine());
}
for (int i = 0; i < flight.Length; i++)
{
    for (int j = 0; j < flight.Length; j++)
    {
        if (flight[j] > flight[i])
        {
           float temp = flight[i];
            flight[i] = flight[j];
            flight[j] = temp;
        }
    }
}
Console.WriteLine("Assending order:");
for (int i = 0; i < flight.Length; i++)
{
    Console.WriteLine(flight[i]);
}
Console.WriteLine("Desending order:");
for (int i = flight.Length - 1; i >= 0; i--)
{
    Console.WriteLine(flight[i]);
}

Console.WriteLine("enter to search:");
a = float.Parse(Console.ReadLine());


int count = 0;

for (int i = 0; i < flight.Length; i++)
{
    if (flight[i] == a)
    {
        Console.WriteLine($"{a}Element found in position{i + 1}");
        count++;
    }

}
Console.WriteLine("max num:");
Console.WriteLine(flight[flight.Length - 1]);

Console.WriteLine("min num:");
Console.WriteLine(flight[0]);

var duplicates = new int[flight.Length];
int k = 0;
foreach (var item in flight)
{
    int count1 = 0;
    foreach (var fare in flight)
    {
        if (item == fare)
        {
            count1++;
        }
        if (count1 >= 2)
        {
            bool hasFoundMatch = false;
            foreach (var str in duplicates)
            {
                if (str == item)
                {
                    hasFoundMatch = true;
                    break;
                }
            }
            if (!hasFoundMatch)
                duplicates[k++] = (int)item;
        }
    }



}
Console.WriteLine("Duplicate element is:");
Console.WriteLine(String.Join("  ", duplicates));


