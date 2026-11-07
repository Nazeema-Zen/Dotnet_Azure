using System;

class StringUpperLower
{
    static void Main()
    {
        string firstName = "Rahul";
        string lastName = "Sharma";

        string fullName = firstName + " " + lastName;

        Console.WriteLine("Full Name: " + fullName);

        Console.WriteLine("Length: " + fullName.Length);

        Console.WriteLine("Uppercase: " + fullName.ToUpper());
        Console.WriteLine("Lowercase: " + fullName.ToLower());

        Console.WriteLine("First Character: " + fullName[0]);

        Console.WriteLine("Contains Rahul: " +
                          fullName.Contains("Rahul"));

        Console.WriteLine("Replace: " +
                          fullName.Replace("Rahul", "Amit"));

        Console.WriteLine("Substring: " +
                          fullName.Substring(0, 5));
    }
}