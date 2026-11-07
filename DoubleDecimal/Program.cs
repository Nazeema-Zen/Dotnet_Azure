using System;

class DoubleDecimal
{
    static void Main()
    {
        double d1 = 0.1;
        double d2 = 0.2;

        decimal m1 = 0.1m;
        decimal m2 = 0.2m;

        Console.WriteLine("Double Result:");
        Console.WriteLine(d1 + d2);

        Console.WriteLine("\nDecimal Result:");
        Console.WriteLine(m1 + m2);
    }
}