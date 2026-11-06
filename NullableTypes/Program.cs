#nullable enable
using System;

class Program
{
    static void Main()
    {
        // int? age = null;

        // Console.WriteLine("Has Value: " + age.HasValue);

        // age = 25;

        // Console.WriteLine("Has Value: " + age.HasValue);

        // Console.WriteLine("Age: " + age.Value);
        // int? marks = null;
        // int finalMarks = marks ?? 0; // ?? null coalescing oparater
        // Console.WriteLine("Final Marks: " + finalMarks);
        // marks = 85;
        // finalMarks = marks ?? 0;
        // Console.WriteLine("Final Marks: " + finalMarks);
        string? name = null;
        Console.WriteLine(name ?? "Name Not Provided");
        name = "Rahul";
        Console.WriteLine(name.ToLower());

    }
}