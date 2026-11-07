using System;

class AgeisAdult
{
    static void Main()
    {
        int age = 20;

        bool isAdult = age >= 18;
        bool hasID = true;

        Console.WriteLine("Is Adult: " + isAdult);
        Console.WriteLine("Has ID: " + hasID);

        bool allowed = isAdult && hasID;

        Console.WriteLine("Allowed: " + allowed);
    }
}