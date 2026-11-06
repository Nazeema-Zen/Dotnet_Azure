using System;

class Program
{
    static void Main()
    {
        byte studentAge = 18;
        short temperature = -150;
        int population = 1500000;
        long worldPopulation = 8000000000L;

        uint totalVisitors = 4000000000U;
        ulong largeNumber = 18000000000000000000UL;

        Console.WriteLine("Student Age: " + studentAge);
        Console.WriteLine("Temperature: " + temperature);
        Console.WriteLine("Popudotnetlation: " + population);
        Console.WriteLine("World Population: " + worldPopulation);
        Console.WriteLine("Visitors: " + totalVisitors);
        Console.WriteLine("Large Number: " + largeNumber);

        Console.WriteLine("\nInteger Ranges");

        Console.WriteLine("Byte Min: " + byte.MinValue);
        Console.WriteLine("Byte Max: " + byte.MaxValue);

        Console.WriteLine("Int Min: " + int.MinValue);
        Console.WriteLine("Int Max: " + int.MaxValue);

        Console.WriteLine("Long Min: " + long.MinValue);
        Console.WriteLine("Long Max: " + long.MaxValue);
    }
}