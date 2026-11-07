using System;

class HeightDistance
{
    static void Main()
    {
        float height = 5.87654321f;
        double distance = 12345.678901234567;

        Console.WriteLine("Float Value: " + height);
        Console.WriteLine("Double Value: " + distance);

        Console.WriteLine("\nSize");

        Console.WriteLine("Float: " + sizeof(float));
        Console.WriteLine("Double: " + sizeof(double));

        Console.WriteLine("\nPrecision");

        Console.WriteLine(
            height.ToString("G9",
                System.Globalization.CultureInfo.InvariantCulture));

        Console.WriteLine(
            distance.ToString("G17",
                System.Globalization.CultureInfo.InvariantCulture));
    }
}